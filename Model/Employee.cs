using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management_Hotel.Model
{
    public class Employee
    {
        public string name_position { get; set; }
        public int id { get; }
        public string fname { get; set; }
        public string lname { get; set; }
        public bool gender { get; set; }
        public DateTime dob { get; set; }
        public string phone { get; set; }
        public string address { get; set; }
        public Image picture { get; set; } 
        public Employee(int id,string fname,string lname, string name_pos, bool gender,
            DateTime dob,string phone,string address,Image pic)
        {
            this.name_position = name_pos;
            this.id = id;
            this.fname = fname;
            this.lname = lname;
            this.gender = gender;
            this.dob = dob;
            this.phone = phone;
            this.address = address;
            this.picture = pic;
        }
        private Image cvtImg(byte[] byteImage)
        {
            if (byteImage == null) return null;
            using (MemoryStream ms = new MemoryStream(byteImage))
            {
                return new Bitmap(ms);
            }
        }
        public Employee(object[] arr)
        {
            this.id = int.Parse(arr[0].ToString());
            this.fname = arr[1].ToString().Trim();
            this.lname = arr[2].ToString().Trim();
            this.name_position = arr[3].ToString().Trim();
            this.gender = (arr[4].ToString().Trim() == "Male");
            this.dob = DateTime.Parse(arr[5].ToString());
            this.phone = arr[6].ToString().Trim();
            this.address = arr[7].ToString().Trim();
            this.picture = this.cvtImg((byte[])arr[8]);
        }
    }
}
