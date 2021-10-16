using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management_Hotel.Model
{
    public class Food
    {
        public string id_food { get; }
        public Image picture { get; set; }
        public string name_food { get; set; }
        public int amount { get; set; }
        public float price { get; set; }
        public Food(object[] arr)
        {
   
            try
            {
                this.id_food = arr[0].ToString().Trim();
                if (arr[1].ToString().Trim().Length!=0) 
                    this.picture = this.cvtImage((byte[])arr[1]);
                this.name_food = arr[2].ToString().Trim();
                this.amount = int.Parse(arr[3].ToString());
                this.price = float.Parse(arr[4].ToString());
            }
            catch (FormatException) { }
        }
        public Food(string id_food,Image picture,string name_food,int amount,float price)
        {
            this.id_food = id_food;
            this.picture = picture;
            this.name_food = name_food;
            this.amount = amount;
            this.price = price;
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
