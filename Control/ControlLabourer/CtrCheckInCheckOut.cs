using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Management_Hotel.Control.ControlManager;
using Management_Hotel.Model;

namespace Management_Hotel.Control.ControlLabourer
{
    public class CtrCheckInCheckOut
    {
        static protected ConnectSql connectSql;
        public CtrCheckInCheckOut()
        {
            connectSql = new ConnectSql();
        }
        public bool removeCheck(int id_employee)
        {
            SqlCommand cmd = new SqlCommand("Delete from CheckInCheckOut " +
                "where id_employee_work=@id_employee"
                    , connectSql.connection);
            cmd.Parameters.Add("@id_employee", SqlDbType.Int).Value = id_employee;
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
        public bool hasWorkToday(int id_employee,string name_shift)
        {
            return (getIdDivision(id_employee, name_shift, DateTime.Now) != null);
           
        }
        public bool doneWorkToday(int id_employee, string name_shif)
        {
            return true;
        }
        public string getIdDivision(int id_employee, string name_shift, DateTime day_start)
        {
            SqlCommand cmd = new SqlCommand("Select id_division from Division where " +
                "id_employee=@id_employee and name_shift=@name_shift and day_start = @day_start"
    , connectSql.connection);
            cmd.Parameters.Add("@id_employee", SqlDbType.Int).Value = id_employee;
            cmd.Parameters.Add("@name_shift", SqlDbType.Char).Value = name_shift;
            cmd.Parameters.Add("@day_start", SqlDbType.Date).Value = day_start ;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable data = new DataTable();
            adapter.Fill(data);
            return (data.Rows.Count == 0) ? null : data.Rows[0][0].ToString().Trim();
        }
        public DateTime getTimeStart(int id_employee)
        {
            SqlCommand cmd = new SqlCommand("Select * from CheckInCheckOut where id_employee_work=@id_employee" +
                " and time_end is null"
    , connectSql.connection);
            cmd.Parameters.Add("@id_employee", SqlDbType.Int).Value = id_employee;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable data = new DataTable();
            adapter.Fill(data);
            if (data.Rows.Count != 0)
            {
                return DateTime.Parse(data.Rows[0][2].ToString());
            }
            else return new DateTime(1 , 1 , 1);
        }
        public bool isChecked(int id_employee)
        {
            SqlCommand cmd = new SqlCommand("Select * from CheckInCheckOut where id_employee_work=@id_employee" +
                " and time_end is null"
                , connectSql.connection);
            cmd.Parameters.Add("@id_employee", SqlDbType.Int).Value = id_employee;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable data = new DataTable();
            adapter.Fill(data);
            return (data.Rows.Count != 0);
        }
 
        public bool checkIn(int id_employee,string name_shift)
        {
            SqlCommand cmd = new SqlCommand("Insert into CheckInCheckOut Values(@id_employee,@id_division,@time_start,null)"
                    , connectSql.connection);
            cmd.Parameters.Add("@id_employee", SqlDbType.Int).Value = id_employee;
            cmd.Parameters.Add("@id_division", SqlDbType.Char).Value = getIdDivision(id_employee, name_shift, DateTime.Now);
            cmd.Parameters.Add("@time_start", SqlDbType.DateTime).Value =  DateTime.Now;
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
        public bool checkOut(int id_employee)
        {
            SqlCommand cmd = new SqlCommand("Update CheckInCheckOut set " +
                "time_end=@time_end where id_employee_work=@id_employee and time_end is null"
                    , connectSql.connection);
            cmd.Parameters.Add("@id_employee", SqlDbType.Int).Value = id_employee;
            cmd.Parameters.Add("@time_end", SqlDbType.DateTime).Value = DateTime.Now;
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
