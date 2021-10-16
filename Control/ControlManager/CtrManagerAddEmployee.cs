using Management_Hotel.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management_Hotel.Control.ControlManager
{
    public class CtrManagerAddEmployee : CtrManager
    {
        public bool isExistingID(int id)
        {
            DataTable data = base.getDataEmployee();
            foreach (DataRow i in data.Rows)
            {
                if (id == (int)i[0]) return true;
            }
            return false;
        }
        public int newID()
        {
            Random rand = new Random();
            int id;
            do
            {
                id = rand.Next(100);
            } while (isExistingID(id));
            return id;
        }

        public bool appendEmployee(Employee employee)
        {
            SqlCommand cmd = new SqlCommand("Insert into Employee Values(@id,@fn,@ln,@name_position," +
                "@gen,@dob,@pho,@add,@pic)", connectSql.connection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = employee.id;
            cmd.Parameters.Add("@name_position", SqlDbType.Char).Value = employee.name_position;
            cmd.Parameters.Add("@fn", SqlDbType.Char).Value = employee.fname;
            cmd.Parameters.Add("@ln", SqlDbType.Char).Value = employee.lname;
            cmd.Parameters.Add("@dob", SqlDbType.DateTime).Value = employee.dob;
            cmd.Parameters.Add("@gen", SqlDbType.Char).Value = (employee.gender == true) ? "Male" : "Female";
            cmd.Parameters.Add("@pho", SqlDbType.Char).Value = employee.phone;
            cmd.Parameters.Add("@add", SqlDbType.Char).Value = employee.address;
            cmd.Parameters.Add("@pic", SqlDbType.Image).Value = this.cvtImg(employee.picture);
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
