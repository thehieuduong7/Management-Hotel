using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management_Hotel.Model
{
    class PhongModel
    {
        public int id_phong { get; set; }
        public String tenPhong { get; set; }
        public String ViTri { get; set; }
        public Image Photo { get; set; }
        public float gia { get; set; }
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
        public PhongModel(int id_phong, string tenPhong, string viTri, Image photo, float gia)
        {
            this.id_phong = id_phong;
            this.tenPhong = tenPhong;
            ViTri = viTri;
            Photo = photo;
            this.gia = gia;
        }
    }
}
