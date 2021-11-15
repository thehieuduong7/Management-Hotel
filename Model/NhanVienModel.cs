using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management_Hotel.Model
{
    public class NhanVienModel
    {
        public int ID { get; set; }
        public String Ho { get; set; }
        public String Ten { get; set; }
        public DateTime NgaySinh { get; set; }
        public String SDT { get; set; }
        public String GioiTinh { get; set; }
        public float Luong { get; set; }
        public Image Avatar { get; set; }
        public String ChucVu { get; set; }

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
        public NhanVienModel(int iD, string ho, string ten, DateTime ngaySinh, string sDT, string gioiTinh, float luong, Image avatar, string chucVu)
        {
            ID = iD;
            Ho = ho;
            Ten = ten;
            NgaySinh = ngaySinh;
            SDT = sDT;
            GioiTinh = gioiTinh;
            Luong = luong;
            Avatar = avatar;
            ChucVu = chucVu;
        }


    }
}
