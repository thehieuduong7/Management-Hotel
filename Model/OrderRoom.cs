using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management_Hotel.Model
{
    public class OrderRoom
    {
        public string id_order { get; set; }
        public string id_room { get; set; }
        public int id_guest { get; set; }
        public DateTime day_order { get; set; }
        public string status { get; set; }
        public OrderRoom(string id_order,string id_room,int id_guest,
            DateTime day_order,string status)
        {
            this.id_order = id_order;
            this.id_room = id_room;
            this.id_guest = id_guest;
            this.day_order = day_order;
            this.status = status;
        }
        public OrderRoom(object[] arr)
        {
            try
            {
                string id_order = arr[0].ToString().Trim();
                string id_room = arr[1].ToString().Trim();
                int id_guest = int.Parse(arr[2].ToString());
                DateTime day_order = DateTime.Parse(arr[3].ToString());
                string status = arr[4].ToString().Trim();
                this.id_order = id_order;
                this.id_room = id_room;
                this.id_guest = id_guest;
                this.day_order = day_order;
                this.status = status;
            }
            catch (FormatException) { }
        }
    }
}
