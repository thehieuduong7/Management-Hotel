using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Management_Hotel.Model
{
    public class AccountNVModel
    {
        String username { get; set; }

        String password { get; set; }
        int id_nv { get; set; }
        String name { get; set; }
        String chucVu { get; set; }
        public AccountNVModel(DataRow row)
        {
            this.username = row[0].ToString().Trim();
            this.password = row[1].ToString().Trim();
            this.id_nv = int.Parse(row[2].ToString());
            this.name = row[3].ToString().Trim();
            this.chucVu = row[4].ToString().Trim();
        }
    }
}
