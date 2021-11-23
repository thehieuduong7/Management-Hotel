using Management_Hotel.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management_Hotel.Control_DAO
{
    class GlobalUser
    {
        public static int idNhanVien { get; set; }
        public static string ChucVu { get; set; }
        public static void clear()
        {
            idNhanVien = -1;
            ChucVu = null;
        }
        public static Image CvtToImg(byte[] byteImage)
        {
            if (byteImage == null) return null;
            using (MemoryStream ms = new MemoryStream(byteImage))
            {
                return new Bitmap(ms);
            }
        }
        public static byte[] cvtToByte(Image img)
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
