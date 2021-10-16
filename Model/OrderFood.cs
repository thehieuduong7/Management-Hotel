using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management_Hotel.Model
{
    public class OrderFood
    {
        public string id_order { get; }
        public string id_food { get; set; }
        public int amount { get; set; }
        public DateTime day_order { get; set; }
        public OrderFood(object[] arr)
        {
            try
            {
                this.id_order = arr[0].ToString().Trim();
                this.id_food = arr[1].ToString().Trim();
                this.amount = int.Parse(arr[2].ToString());
                this.day_order = DateTime.Parse(day_order.ToString());
            }
            catch (FormatException) { }
        }
        public OrderFood(string id_order,string id_food,int amount,DateTime day_order)
        {
            this.id_order = id_order;
            this.id_food = id_food;
            this.amount = amount;
            this.day_order = day_order;
        }
    }
}
