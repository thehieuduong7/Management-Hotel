using Management_Hotel.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management_Hotel.Control.ControlManager
{
    public class CtrManager
    {
        static protected ConnectSql connectSql;
        public CtrManager()
        {
            connectSql = new ConnectSql();
        }
        


        public Employee getEmployee(int id)
        {
            DataTable data = this.getDataEmployee();
            foreach(DataRow row in data.Rows)
            {
                if (int.Parse(row[0].ToString()) == id)
                {
                    return new Employee(row.ItemArray);
                }
            }
            return null; 
        }
        public Shift getShift(string name_shift)
        {
            DataTable data = this.getDataShift();
            foreach (DataRow row in data.Rows)
            {
                if (row[0].ToString().Trim() == name_shift)
                {
                    return new Shift(row.ItemArray);
                }
            }
            return null;
        }
        public Position getPosition(string name_position)
        {
            DataTable data = this.getDataPosition();
            foreach (DataRow row in data.Rows)
            {
                if (row[0].ToString().Trim() == name_position)
                {
                    return new Position(row.ItemArray);
                }
            }
            return null;
        }

        public DivisionEmployee getDivisionEmployee(string id_division)
        {
            DataTable data = this.getDataDivison();
            foreach (DataRow row in data.Rows)
            {
                if (row[0].ToString().Trim() == id_division)
                {
                    return new DivisionEmployee(row.ItemArray);
                }
            }
            return null;
        }
        public DataTable getDataEmployee()
        {
            SqlCommand cmd = new SqlCommand("Select * from Employee", connectSql.connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }
        public DataTable getDataPosition()
        {
            SqlCommand cmd = new SqlCommand("Select * from Position", connectSql.connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }
        public DataTable getDataShift()
        {
            SqlCommand cmd = new SqlCommand("Select * from Shifts", connectSql.connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }
        public DataTable getDataCheck()
        {
            SqlCommand cmd = new SqlCommand("Select * from CheckInCheckOut", connectSql.connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }
        public DataTable getDataDivison()
        {
            SqlCommand cmd = new SqlCommand("Select * from Division", connectSql.connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }
        public byte[] cvtImg(Image img)
        {
            if (img == null) return null;
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }
    }
}
