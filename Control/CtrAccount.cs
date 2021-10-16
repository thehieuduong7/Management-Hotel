using Management_Hotel.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management_Hotel.Control
{
    public class CtrAccount
    {
        private static ConnectSql connectSql= new ConnectSql();
        public CtrAccount()
        {
        }
        public DataTable getDataAccount()
        {
            SqlCommand cmd = new SqlCommand("Select Account.id_employee,Account.username,Account.password, " +
                "Employee.name_position from Account " +
                "Inner join Employee On Account.id_employee = Employee.id ", connectSql.connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }
        public Account getAccount(int id_employee)
        {
            DataTable data = this.getDataAccount();
            foreach (DataRow row in data.Rows)
            {
                if (int.Parse(row[0].ToString()) == id_employee)
                    return new Account(row.ItemArray);
            }
            return null;
        }
        public int accessAccount(Account acc, string pos)       //return id, -1 = null
        {
            DataTable data = this.getDataAccount();
            foreach (DataRow row in data.Rows)
            {
                if (row[1].ToString().Trim() == acc.username &&
                    row[2].ToString().Trim() == acc.password && row[3].ToString().Trim() == pos) return int.Parse(row[0].ToString());
            }
            return -1;
        }
        public bool isExistingUsername(string username)
        {
            DataTable data = this.getDataAccount();
            foreach (DataRow row in data.Rows)
            {
                if (row[1].ToString().Trim() == username) return true;
            }
            return false;
        }
        public bool appendAccount(Account acc)
        {
            SqlCommand cmd = new SqlCommand("Insert into Account Values(@id,@user,@pass)", connectSql.connection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = acc.id;
            cmd.Parameters.Add("@user", SqlDbType.NVarChar).Value = acc.username;
            cmd.Parameters.Add("@pass", SqlDbType.NVarChar).Value = acc.password;
            connectSql.open();
            bool result = false;
            try
            {
                result = (cmd.ExecuteNonQuery() == 1);
            }
            catch (SqlException)
            {
                return false;
            }
            finally
            {
                connectSql.close();
            }
            return result;
        }
        public bool updateAccount(Account acc)
        {
            SqlCommand cmd = new SqlCommand("Update Account set password=@pass where id_employee=@id", connectSql.connection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = acc.id;
            cmd.Parameters.Add("@pass", SqlDbType.NVarChar).Value = acc.password;
            connectSql.open();
            bool result = false;
            try
            {
                result = (cmd.ExecuteNonQuery() == 1);
            }
            catch (FormatException)
            {
                return false;
            }
            finally
            {
                connectSql.close();
            }
            return result;
        }
        public static bool removeAccount(int id_employee)
        {
            SqlCommand cmd = new SqlCommand("Delete from Account where id_employee=@id", connectSql.connection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id_employee;
            connectSql.open();
            bool result = false;
            try
            {
                result = (cmd.ExecuteNonQuery() == 1);
            }
            catch (SqlException exc)
            {
                return false;
            }
            finally
            {
                connectSql.close();
            }
            return result;
        }
    }
}
