using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management_Hotel.Model
{
    public class Account
    {
        public string username { get; }
        public string password { get; set; }
        public int id { get; }
        public Account(string user, string pass)
        {
            this.username = user;
            this.password = pass;
        }
        public Account(int id, string user, string pass) : this(user, pass)
        {
            this.id = id;
        }
        public Account(object[] arr)
        {
            try
            {
                int id = int.Parse(arr[0].ToString());
                string user = arr[1].ToString().Trim();
                string pass = arr[2].ToString().Trim();
                this.id = id;
                this.username = user;
                this.password = pass;
            }
            catch(FormatException)
            {

            }

        }
    }
}
