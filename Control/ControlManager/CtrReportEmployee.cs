using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Management_Hotel.Model;
namespace Management_Hotel.Control.ControlManager
{
    class CtrReportEmployee:CtrManager
    {
        public DataTable getCheckInCheckOut(DateTime now)
        {
            SqlCommand cmd = new SqlCommand("select q.id_employee,q.id_division," +
                "CheckInCheckOut.time_start,CheckInCheckOut.time_end" +
                " from CheckInCheckOut right join " +
                "(select Division.id_employee as id_employee,Division.id_division as id_division" +
                " from Division where Division.day_start = @day_start ) as q" +
                " on q.id_employee = CheckInCheckOut.id_employee_work" +
                " and CheckInCheckOut.id_division = q.id_division ");
            cmd.Connection = connectSql.connection;
            cmd.Parameters.Add("@day_start", SqlDbType.Date).Value = now;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }

        public DataTable getDataReport(DateTime now)
        {
            DataTable data = new DataTable();
            string[] colName ={"Name shift","ID Employee","Picture","Full Name","Position"
                    ,"Total Money"};
            foreach(string name in colName)
            {
                data.Columns.Add(name);
            }
            data.Columns[2].DataType= System.Type.GetType("System.Byte[]");
            DataTable dataCheck = getCheckInCheckOut(now);
            foreach(DataRow row in dataCheck.Rows)
            {
                CheckInCheckOut check = new CheckInCheckOut(row.ItemArray);
                DivisionEmployee division = this.getDivisionEmployee(row[1].ToString().Trim());
                Shift shift = this.getShift(division.name_shift);
                Employee employee = this.getEmployee(int.Parse(row[0].ToString()));
                Position pos = this.getPosition(employee.name_position);
                if (pos.name_position == "Manager") continue;
                ReportEmpolyeeWork report = new ReportEmpolyeeWork(employee, pos, division, shift, check);
                DataRow row_data = data.NewRow();
                data.Rows.Add(report.toDataRow(row_data));
            }
            return data;
        }
        public ReportEmpolyeeWork getReport(int id_employee,DateTime day_start)
        {
            DataTable dataCheck = getCheckInCheckOut(day_start);
            foreach (DataRow row in dataCheck.Rows)
            {
                if (int.Parse(row[0].ToString()) == id_employee)
                {
                    CheckInCheckOut check = new CheckInCheckOut(row.ItemArray);
                    DivisionEmployee division = this.getDivisionEmployee(row[1].ToString().Trim());
                    Shift shift = this.getShift(division.name_shift);
                    Employee employee = this.getEmployee(int.Parse(row[0].ToString()));
                    Position pos = this.getPosition(employee.name_position);
                    return new ReportEmpolyeeWork(employee, pos, division, shift, check);
                }
            }
            return null;
        }
        public float TotalMoney(DateTime day_start)
        {
            DataTable data = this.getDataReport(day_start);
            float sum = 0;
            foreach(DataRow row in data.Rows)
            {
                try
                {
                    float money = float.Parse(row[5].ToString());
                    sum += money;
                }
                catch (FormatException)
                {
                    continue;
                }
            }
            return sum;
        }
    }
    public enum TimeWork
    {
        new_day_hour = 6,
        new_day_minute=30,
        new_day_second=0,
    }
}
