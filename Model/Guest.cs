using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management_Hotel.Model
{
    public class Guest
    {
        public int id_guest { get; }
        public string full_name { get; set; }
        public int age { get; set; }
        public string gender { get; set; }
        public string phone { get; set; }
        public Image picture { get; set; }
        public Guest(object[] arr)
        {
            try
            {
                this.id_guest = int.Parse(arr[0].ToString());
                this.full_name = arr[1].ToString();
                this.age = int.Parse(arr[2].ToString());
                this.gender = arr[3].ToString().Trim();
                this.phone = arr[4].ToString().Trim();
                this.picture = this.cvtImage((byte[])arr[5]);
            }
            catch (FormatException) { }
        }
        public Guest
            (int id_guest,string full_name,int age,string gender,string phone,Image picture)
        {
            this.id_guest = id_guest;
            this.full_name = full_name;
            this.age = age;
            this.gender = gender;
            this.phone = phone;
            this.picture = picture;
        }
        public Image cvtImage(byte[] byteImage)
        {
            using (MemoryStream u = new MemoryStream(byteImage))
            {
                return Image.FromStream(u);
            }
        }
        public byte[] cvtByte(Image img)
        {
            if (img == null) return null;
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }
    }
}
