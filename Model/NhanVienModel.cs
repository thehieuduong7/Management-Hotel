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
        int ID { get; set; }
        String Ho { get; set; }
        String Ten { get; set; }
        DateTime NgaySinh { get; set; }
        String SDT { get; set; }
        String GioiTinh { get; set; }
        float Luong { get; set; }
        Image Avatar { get; set; }
        String ChucVu { get; set; }

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

        public NhanVienModel(DataRow row)
        {
            ID = int.Parse(row[0].ToString());
            Ho = row[1].ToString().Trim();
            Ten = row[2].ToString().Trim();
            NgaySinh = DateTime.Parse(row[3].ToString());
            SDT = row[4].ToString().Trim();
            GioiTinh = row[5].ToString().Trim();
            Luong = float.Parse(row[6].ToString());
            Avatar = CvtByteToImg((byte[])row[7]);
            ChucVu = row[8].ToString().Trim();
        }

    }
}
