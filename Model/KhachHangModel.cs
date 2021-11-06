using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management_Hotel.Model
{
    public class KhachHangModel
    {
        public int id_kh { get; set; }
        public String Ho { get; set; }
        public String Ten { get; set; }
        public DateTime NgaySinh { get; set; }
        public String SDT { get; set; }
        public String GioiTinh { get; set; }
        public Image Avatar { get; set; }

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
        public KhachHangModel(DataRow row)
        {
            id_kh = int.Parse(row[0].ToString());
            Ho = row[1].ToString().Trim();
           Ten= row[2].ToString().Trim();
            NgaySinh = DateTime.Parse(row[3].ToString());
            SDT= row[4].ToString().Trim();
            GioiTinh= row[5].ToString().Trim();
            Avatar = CvtByteToImg((byte[])row[6]);
        }

        public KhachHangModel(int id_kh, string ho, string ten, DateTime ngaySinh, string sDT, string gioiTinh, Image avatar)
        {
            this.id_kh = id_kh;
            Ho = ho;
            Ten = ten;
            NgaySinh = ngaySinh;
            SDT = sDT;
            GioiTinh = gioiTinh;
            Avatar = avatar;
        }
    }

}
