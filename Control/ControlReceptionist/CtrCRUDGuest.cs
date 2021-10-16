using Management_Hotel.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management_Hotel.Control.ControlReceptionist
{
    public class CtrCRUDGuest
    {
        ConnectSql connectSql;
        public CtrCRUDGuest()
        {
            this.connectSql = new ConnectSql();
        }
        public bool isExistingID(int id_guest)
        {
            DataTable data = getDataGuest();
            foreach (DataRow row in data.Rows)
            {
                if (int.Parse(row[0].ToString()) == id_guest)
                {
                    return true;
                }
            }
            return false;
        }
        public int new_id_guest()
        {
            Random rand = new Random();
            int id;
            do
            {
                id = rand.Next(10000);
            } while (this.isExistingID(id));
            return id;
        }
        public Guest getGuestByID(int id_guest)
        {
            DataTable data = getDataGuest();
            foreach(DataRow row in data.Rows)
            {
                if (int.Parse(row[0].ToString()) == id_guest) 
                    return new Guest(row.ItemArray);
            }
            return null;
        }
        public DataTable getDataGuest()
        {
            SqlCommand cmd = new SqlCommand("Select * from Guest");
            cmd.Connection = connectSql.connection;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        
        public bool insertGuest(Guest guest)
        {
            SqlCommand cmd = new SqlCommand("Insert into Guest Values" +
                "(@id_guest,@full_name,@age,@gender,@phone,@picture)", connectSql.connection);
            cmd.Parameters.Add("@id_guest", SqlDbType.Int).Value = guest.id_guest;
            cmd.Parameters.Add("@full_name", SqlDbType.Char).Value = guest.full_name;
            cmd.Parameters.Add("@age", SqlDbType.Int).Value = guest.age;
            cmd.Parameters.Add("@gender", SqlDbType.Char).Value = guest.gender;
            cmd.Parameters.Add("@phone", SqlDbType.Char).Value = guest.phone;
            cmd.Parameters.Add("@picture", SqlDbType.Image).Value = guest.cvtByte(guest.picture);
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
        public bool updateGuest(Guest guest)
        {
            SqlCommand cmd = new SqlCommand("update Guest set " +
                "full_name=@full_name,age=@age,gender=@gender,phone=@phone,picture=@picture" +
                " where id_guest=@id_guest",
                connectSql.connection);
            cmd.Parameters.Add("@id_guest", SqlDbType.Int).Value = guest.id_guest;
            cmd.Parameters.Add("@full_name", SqlDbType.Char).Value = guest.full_name;
            cmd.Parameters.Add("@age", SqlDbType.Int).Value = guest.age;
            cmd.Parameters.Add("@gender", SqlDbType.Char).Value = guest.gender;
            cmd.Parameters.Add("@phone", SqlDbType.Char).Value = guest.phone;
            cmd.Parameters.Add("@picture", SqlDbType.Image).Value = guest.cvtByte(guest.picture);
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
        public bool removeGuest(int id_guest)
        {
            SqlCommand cmd = new SqlCommand("delete from Guest where id_guest=@id_guest",
                connectSql.connection);
            cmd.Parameters.Add("@id_guest", SqlDbType.Int).Value = id_guest;
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
