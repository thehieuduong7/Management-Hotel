using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management_Hotel.Model
{
    public class Position
    {
        public string name_position { get; }
        public float salary { get; }
        public float fine_money { get; }
        public float over_money { get; }
        public Position(object[] arr)
        {
            name_position = arr[0].ToString().Trim();
            if (name_position != "Manager")
            {
                salary = float.Parse(arr[1].ToString());
                fine_money = float.Parse(arr[2].ToString());
                over_money = float.Parse(arr[3].ToString());
            }

        }
    }
}
