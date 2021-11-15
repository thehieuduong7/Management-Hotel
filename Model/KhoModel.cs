using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management_Hotel.Model
{
    public class KhoModel
    {
        public int id_mon { get; set; }
        public String tenMon { get; set; }
        public int soLuong { get; set; }
        public float GiaGoc { get; set; }
        public float giaBan { get; set; }
        public Image photo { get; set; }
        public Image CvtToImg(byte[] byteImage)
        {
            if (byteImage == null) return null;
            using (MemoryStream ms = new MemoryStream(byteImage))
            {
                return new Bitmap(ms);
            }
        }
        public byte[] cvtToByte(Image img)
        {
            if (img == null) return null;
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }
        public KhoModel(int id_mon, string tenMon, int soLuong, float giaGoc, float giaBan, Image photo)
        {
            this.id_mon = id_mon;
            this.tenMon = tenMon;
            this.soLuong = soLuong;
            GiaGoc = giaGoc;
            this.giaBan = giaBan;
            this.photo = photo;
        }
    }
}
