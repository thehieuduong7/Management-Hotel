using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Management_Hotel.Control.ControlLabourer;
using Management_Hotel.Model;
namespace Management_Hotel.Control.ControlManager
{
    public class CtrManagerEditEmployee:CtrManager
    {
        public DataTable getTotal()
        {
            SqlCommand cmd = new SqlCommand("Select name_position, count(Employee.id) from Employee " +
                "group by name_position", connectSql.connection); //order by ASC Position.id 
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }
        public bool updateEmployee(Employee employee)
        {
            SqlCommand cmd = new SqlCommand("Update Employee Set " +
                "first_name=@fn,last_name=@ln,name_position=@name_pos,gender= @gen,dob=@dob," +
                "phone=@pho,address=@add,picture=@pic " +
                "Where id=@id", connectSql.connection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = employee.id;
            cmd.Parameters.Add("@name_pos", SqlDbType.Char).Value = employee.name_position;
            cmd.Parameters.Add("@fn", SqlDbType.NVarChar).Value = employee.fname;
            cmd.Parameters.Add("@ln", SqlDbType.NVarChar).Value = employee.lname;
            cmd.Parameters.Add("@dob", SqlDbType.DateTime).Value = employee.dob;
            cmd.Parameters.Add("@gen", SqlDbType.NVarChar).Value = (employee.gender == true) ? "Male" : "Female";
            cmd.Parameters.Add("@pho", SqlDbType.NVarChar).Value = employee.phone;
            cmd.Parameters.Add("@add", SqlDbType.NVarChar).Value = employee.address;
            cmd.Parameters.Add("@pic", SqlDbType.Image).Value = this.cvtImg(employee.picture);
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
        public bool removeEmployee(int id)
        {
            CtrAccount.removeAccount(id);
            CtrCheckInCheckOut Ctrcheck = new CtrCheckInCheckOut();
            Ctrcheck.removeCheck(id);
            CtrDivisionEmployee.removeDivision(id);
            SqlCommand cmd = new SqlCommand("Delete from Employee where id=@id",connectSql.connection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
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
    }
}
