using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management_Hotel.Model
{
    public class DatPhongModel
    {
        int maDat { get; set; }
        int id_kh { get; set; }
        int id_phong { get; set; }
        int id_nv { get; set; }
        DateTime ngayDat { get; set; }
        String TrangThai { get; set; }

        public DatPhongModel(int maDat, int id_kh, int id_phong, int id_nv, DateTime ngayDat, string trangThai)
        {
            this.maDat = maDat;
            this.id_kh = id_kh;
            this.id_phong = id_phong;
            this.id_nv = id_nv;
            this.ngayDat = ngayDat;
            TrangThai = trangThai;
        }
    }
}
