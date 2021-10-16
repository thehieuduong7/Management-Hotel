using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Management_Hotel.Model
{
    public class DivisionEmployee
    {
        public DivisionEmployee(string id_division,int id_emp,string name_shift,DateTime day)
        {
            this.id_division = id_division;
            this.id_employee = id_emp;
            this.name_shift = name_shift;
            this.day_start = day;
        }
        public static DataTable newDataTable()
        {
            DataTable data = new DataTable();
            data.Columns.Add("id_division");
            data.Columns.Add("id_employee");
            data.Columns.Add("shift");
            data.Columns.Add("day_start");
            return data;
        }
        public DivisionEmployee(object[] arr)
        {
            try
            {
                string id_division = arr[0].ToString().Trim();
                int id_emp = int.Parse(arr[1].ToString());
                string name_shift = arr[2].ToString().Trim();
                DateTime day = DateTime.Parse(arr[3].ToString());
                this.id_division = id_division;
                this.id_employee = id_emp;
                this.name_shift = name_shift;
                this.day_start = day;
            }
            catch (FormatException) { }
        }
        public string id_division { get; }
        public int id_employee { get; set; }
        public string name_shift { get; set; }
        public DateTime day_start { get; set; }
    }
}
