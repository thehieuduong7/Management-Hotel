using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management_Hotel.Model
{
    public class CheckInCheckOut
    {
        public int id_employee_work{ get; set; }
        public string id_division { get; set; }
        public DateTime time_start;// { get; set; }
        public DateTime time_end { get; set; }
        public string status { get; set; }
        public CheckInCheckOut(object[] arr)
        {
            id_employee_work = int.Parse(arr[0].ToString());
            id_division = arr[1].ToString().Trim();
            if (arr[2].ToString().Trim() != "")
            {
                time_start = DateTime.Parse(arr[2].ToString());
                if (arr[3].ToString().Trim() != "")
                {
                    time_end = DateTime.Parse(arr[3].ToString());
                    this.status = "Done";
                }
                else
                {
                    this.status = "Processing";
                }
            }
            else
            {
                this.status = "Absent";
            }
            
     
        }
    }

}
