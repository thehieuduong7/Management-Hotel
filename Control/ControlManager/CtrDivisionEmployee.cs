using Management_Hotel.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management_Hotel.Control.ControlManager
{
    public class CtrDivisionEmployee:CtrManager
    {
        private WeekInMonth week;
        public CtrDivisionEmployee()
        {
            week = new WeekInMonth();
            update();
        }
        private void update()
        {
            if (checkUpdate())
            {
                updateDivisionLabourer();
                updateDivisionManager();
                updateDivisionReceptionist();
            }
        }
        private DataTable newDataTableDivision(DataTable data_division)
        {
            DataTable dataEmployee = this.getDataEmployee();
            DataTable data = new DataTable();
            data.Columns.Add("Position");
            data.Columns.Add("ID Employee");
            data.Columns.Add("Full Name");
            data.Columns.Add("Monday");
            data.Columns.Add("Tuesday");
            data.Columns.Add("Wednesday");
            data.Columns.Add("Thursday");
            data.Columns.Add("Friday");
            data.Columns.Add("Saturday");
            data.Columns.Add("Sunday");
            DataRow row;
            foreach(DataRow rowEmployee in dataEmployee.Rows)
            {
                row = data.NewRow();
                row["Position"] = rowEmployee["name_position"];
                row["ID Employee"] = rowEmployee["id"];
                row["Full Name"] = rowEmployee["first_name"].ToString().Trim() +
                    " " + rowEmployee["last_name"].ToString().Trim();
                int id = int.Parse(rowEmployee["id"].ToString());
                data_division.DefaultView.RowFilter = string.Format("[id]={0}", id);
                DataTable dataDivisionEmployeeInWeek = data_division.DefaultView.ToTable();
                foreach(DataRow rowDivisionEmployee in dataDivisionEmployeeInWeek.Rows)
                {
                    DateTime date = DateTime.Parse(rowDivisionEmployee["day_start"].ToString());
                    if (row[date.DayOfWeek.ToString()].ToString().Trim() != "")
                    {
                        row[date.DayOfWeek.ToString()] += (","+rowDivisionEmployee["name_shift"].ToString().Trim());
                    }
                    else
                    {
                        row[date.DayOfWeek.ToString()] = rowDivisionEmployee["name_shift"].ToString().Trim();
                    }
                    
                }
                data.Rows.Add(row);
            }
            return data;
        }

        public DataTable[] getDataDivisionInWeeks()
        {
            DataTable data = this.getDataDivision(false);
            DateTime now = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            int maxDay = DateTime.DaysInMonth(now.Year, now.Month);
            List<DataTable> list = new List<DataTable>();
            while (true)
            {
                DateTime end = week.nextSunday(now);
                data.DefaultView.RowFilter = string.Format("[day_start] >= #{0:MM/dd/yyyy}# and" +
                    " [day_start] <= #{1:MM/dd/yyyy}#", now, end);
                list.Add(newDataTableDivision(data.DefaultView.ToTable()));
                if (end.Day == maxDay)
                {
                    return list.ToArray();
                }
                else
                {
                    now = end.AddDays(1);
                }
            }
           
        }
        /// <summary>
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>

        public DataTable getDataDivision(bool full) //in month
        {
            update();
            SqlCommand cmd;
            if (full)
            {
                cmd = new SqlCommand("select Division.id_division, Employee.id, Employee.first_name," +
                    " Employee.last_name,Employee.name_position,Shifts.name_shift, Shifts.time_start, Shifts.time_end," +
                    " Division.day_start from Division " +
                    " inner join Employee on Division.id_employee = Employee.id" +
                    " inner join Shifts on Division.name_shift = Shifts.name_shift"
                    , connectSql.connection);
            }
            else
            {
                cmd = new SqlCommand("select Division.id_division, Employee.id, Employee.first_name," +
                    " Employee.last_name,Employee.name_position,Shifts.name_shift, Shifts.time_start, Shifts.time_end," +
                    " Division.day_start from Division " +
                    " inner join Employee on Division.id_employee = Employee.id" +
                    " inner join Shifts on Division.name_shift = Shifts.name_shift" +
                    " where Division.day_start>@now", connectSql.connection);
                cmd.Parameters.Add("@now", SqlDbType.Date).Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).AddDays(-1);//DateTime.Now;
            }
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }
        public static bool removeDivision(int id_employee)
        {
            SqlCommand cmd = new SqlCommand("Delete from Division where id_employee=@id",
                connectSql.connection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id_employee;
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

        /// <Division>
        private int lenJobLabourer(DateTime date)       //tinh theo thu 7 cn
        {
            return ((int)date.DayOfWeek == 6 || (int)date.DayOfWeek == 0) ? 3 : 5;

        }
        private int lenJobRecept(int day, int lenRecept, int lenManager)   //day tinh theo ti le
        {
            int rate = (int)((float)lenRecept / lenManager);
            int stt = day % (rate + 1);
            if (stt == 0) return 2;
            else return 3;
        }
        // theo stt 1,2 ca 1----3,4 ca 2----5 ca 3
        private string ShiftLabourer(int stt, bool specialDay)
        {
            if (specialDay)
            {
                switch (stt){
                    case 1: 
                        return "Morning";
                    case 2:
                        return "Afternoon";
                    case 3:
                        return "Night";
                }
            }
            else
            {
                if (stt == 1 || stt == 2)
                {
                    return "Morning";
                }
                else if (stt == 3 || stt == 4)
                {
                    return "Afternoon";
                }
                else
                {
                    return "Night";
                }
            }
            return null;
        }
        private int[] Randomize(int[] input)
        {
            List<int> inputList = input.ToList();
            int[] output = new int[input.Length];
            Random rand = new Random();
            int i = 0;
            while (inputList.Count > 0)
            {
                int index = rand.Next(inputList.Count);
                output[i++] = inputList[index];
                inputList.RemoveAt(index);
            }
            return (output);
        }
        private int[] getIDLabourers()
        {
            SqlCommand cmd = new SqlCommand("Select id from Employee Where name_position='Labourer'", connectSql.connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable data = new DataTable();
            adapter.Fill(data);
            List<int> list = new List<int>();
            foreach (DataRow row in data.Rows)
            {
                list.Add(int.Parse(row[0].ToString()));
            }
            return list.ToArray();
        }
        private int[] getIDReceptionist()
        {
            SqlCommand cmd = new SqlCommand("Select id from Employee Where name_position='Receptionist'", connectSql.connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable data = new DataTable();
            adapter.Fill(data);
            List<int> list = new List<int>();
            foreach (DataRow row in data.Rows)
            {
                list.Add(int.Parse(row[0].ToString()));
            }
            return list.ToArray();
        }
        private int[] getIDManager()
        {
            SqlCommand cmd = new SqlCommand("Select id from Employee Where name_position='Manager'", connectSql.connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable data = new DataTable();
            adapter.Fill(data);
            List<int> list = new List<int>();
            foreach (DataRow row in data.Rows)
            {
                list.Add(int.Parse(row[0].ToString()));
            }
            return list.ToArray();
        }
        public bool appendDivision(DataTable data)
        {
            foreach (DataRow row in data.Rows)
            {
                DivisionEmployee div = new DivisionEmployee(row.ItemArray);
                if (!appendDivision(div)) return false;
            }
            return true;
        }
        public bool appendDivision(DivisionEmployee division)
        {
            SqlCommand cmd = new SqlCommand("Insert into division Values(@id_division,@id_emp,@id_shift,@day)", connectSql.connection);
            cmd.Parameters.Add("@id_division", SqlDbType.Char).Value = division.id_division;
            cmd.Parameters.Add("@id_emp", SqlDbType.Int).Value = division.id_employee;
            cmd.Parameters.Add("@id_shift", SqlDbType.Char).Value = division.name_shift;
            cmd.Parameters.Add("@day", SqlDbType.DateTime).Value = division.day_start;
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
        private bool checkUpdate()
        {
            SqlCommand cmd = new SqlCommand("Select * from Division where day_start>@now", connectSql.connection);
            DateTime date = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).AddDays(-1);
            cmd.Parameters.Add("@now", SqlDbType.Date).Value = date ;
                //DateTime.Now;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable data = new DataTable();
            adapter.Fill(data);
            if (DateTime.Now.Day == 1 || data.Rows.Count == 0)
            {
                return true;
            }
            else return false;
        }
        private string hashId(string position,int stt,DateTime date)
        {
            string head = position.Substring(0, 3);
            return head + date.Month.ToString() + stt.ToString();
        }
        private void updateDivisionLabourer()
        {
            DateTime now;// = DateTime.Now;
            now = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);// dau thang'
            int[] id_labourer = Randomize(getIDLabourers());
            DataTable data = DivisionEmployee.newDataTable();
            DataRow row;
            int lenDay = DateTime.DaysInMonth(now.Year, now.Month) - now.Day + 1;
            int lenLabourer = id_labourer.Length;
            int startIndex = 0;
            int id_div = 0;
            int step = (lenLabourer - 5 > 5) ? 5 : 1;
            int count = 0;
            for (int day = 0; day < lenDay; day++)
            {
                int index = startIndex;
                int lenghtJob = lenJobLabourer(now);
                for (int stt = 1; stt <= lenghtJob; stt++)
                {
                    row = data.NewRow();
                    row[0] = hashId("Labourer", count++, now);
                    row[1] = id_labourer[index];
                    row[2] = ShiftLabourer(stt, lenghtJob == 3);
                    row[3] = now.ToString("MM/dd/yyyy");
                    id_div++;
                    if (index == lenLabourer - 1)
                    {
                        index = 0;
                    }
                    else
                    {
                        index++;
                    }
                    data.Rows.Add(row);
                }
                for (int stp = 0; stp < step; stp++)
                {
                    if (startIndex == lenLabourer - 1)      //tang chi so nguoi bat dau
                    {
                        startIndex = 0;
                    }
                    else
                    {
                        startIndex++;
                    }
                }
                now = now.AddDays(1);
            }
            this.appendDivision(data);
        }
        private void updateDivisionReceptionist()
        {
            DateTime now = DateTime.Now;
            now = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);//
            DataRow row;
            DataTable data = DivisionEmployee.newDataTable();
            int lenDay = DateTime.DaysInMonth(now.Year, now.Month) - now.Day + 1;
            int[] IDs = Randomize(getIDReceptionist());
            int lenRecept = IDs.Length;
            int lenManager = getIDManager().Length;
            int startIndex = 0;
            int id_div = 0;
            int step = (lenRecept - 3 > 3) ? 3 : 1;             //ngay sau bat dau tu` indexStart+step
            int count = 0;
            for (int day = 0; day < lenDay; day++)
            {
                int index = startIndex;
                int lenghtJob = lenJobRecept(day, lenRecept, lenManager);
                for (int stt = 1; stt <= lenghtJob; stt++)
                {
                    row = data.NewRow();
                    row[0] = hashId("Reception", count++, now);
                    row[1] = IDs[index];
                    row[2] = ShiftLabourer(stt, true);          //stt=1=morning giong labourer
                    row[3] = now.ToString("MM/dd/yyyy");
                    id_div++;
                    if (index == lenRecept - 1)
                    {
                        index = 0;
                    }
                    else
                    {
                        index++;
                    }
                    data.Rows.Add(row);
                }
                for (int stp = 0; stp < step; stp++)
                {
                    if (startIndex == lenRecept - 1)      //tang chi so nguoi bat dau
                    {
                        startIndex = 0;
                    }
                    else
                    {
                        startIndex++;
                    }
                }
                now = now.AddDays(1);
            }
            this.appendDivision(data);
        }
        private void updateDivisionManager()
        {
            DateTime now = DateTime.Now;
            now = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);//
            DataRow row;
            DataTable data = DivisionEmployee.newDataTable();
            int lenDay = DateTime.DaysInMonth(now.Year, now.Month) - now.Day + 1;
            int[] IDs = Randomize(getIDManager());
            int lenRecept = getIDReceptionist().Length;
            int lenManager = IDs.Length;
            int startIndex = 0;
            int step = (lenManager - 3 > 3) ? 3 : 1;
            int count = 0;
            for (int day = 0; day < lenDay; day++)
            {
                int index = startIndex;
                int lenghtJob = (lenJobRecept(day, lenRecept, lenManager) == 3) ? 2 : 3;    //repcetion=3 thi manager = 2
                for (int stt = 1; stt <= lenghtJob; stt++)
                {
                    row = data.NewRow();
                    row[0] = hashId("Manager", count++, now);
                    row[1] = IDs[index];
                    row[2] = ShiftLabourer(stt, true);
                    row[3] = now.ToString("MM/dd/yyyy");
                    if (index == lenManager - 1)
                    {
                        index = 0;
                    }
                    else
                    {
                        index++;
                    }
                    data.Rows.Add(row);
                }
                for (int stp = 0; stp < step; stp++)
                {
                    if (startIndex == lenManager - 1)      //tang chi so nguoi bat dau
                    {
                        startIndex = 0;
                    }
                    else
                    {
                        startIndex++;
                    }
                }
                now = now.AddDays(1);
            }
            this.appendDivision(data);
        }
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>

    }
    public class WeekInMonth
    {
        public int lenWeek { get; }
        public int getMunberSundayInMonth()//so ngay chu? nhat trong thang
        {
            DateTime day_start = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            int maxDay = DateTime.DaysInMonth(day_start.Year, day_start.Month);
            int count = 0;
            while (true)
            {
                DateTime end = nextSunday(day_start);
                count++;
                if (end.Day == maxDay)
                {
                    return count;
                }
                else
                {
                    day_start = end.AddDays(1);
                }
            }
        }

        public WeekInMonth()
        {
            lenWeek = getMunberSundayInMonth();
        }
        public DateTime nextSunday(DateTime day_start)
        {
            DateTime sunday = new DateTime(day_start.Year, day_start.Month, day_start.Day);
            int maxDay = DateTime.DaysInMonth(day_start.Year, day_start.Month);
            while (sunday.DayOfWeek != DayOfWeek.Sunday && sunday.Day != maxDay)
            {
                sunday = sunday.AddDays(1);
            }
            return sunday;
        }
        public string getWeek(int indexWeek)
        {
            if (indexWeek <= 0 || indexWeek > lenWeek)
            {
                return null;
            }
            else
            {
                int countWeek = 1;
                DateTime day_start = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                DateTime day_end = nextSunday(day_start);
                while (countWeek != indexWeek)
                {
                    day_start = day_end.AddDays(1);
                    day_end = nextSunday(day_start);
                    countWeek++;
                }
                return String.Format("Between {0:MM/dd/yyyy} and {1:MM/dd/yyyy}", day_start, day_end);
            }
        }
    }
}
