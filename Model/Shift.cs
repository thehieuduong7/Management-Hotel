using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management_Hotel.Model
{
    public class Shift
    {
        public string name_shift { get; }
        public TimeSpan time_start { get; set; }
        public TimeSpan time_end { get; set; }
        public Shift(object[] arr)
        {
            name_shift = arr[0].ToString().Trim();
            time_start = TimeSpan.Parse(arr[1].ToString());
            time_end = TimeSpan.Parse(arr[2].ToString());
        }
    }
}
