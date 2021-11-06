using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management_Hotel.Model
{
    class DatMonModel
    {
        int id_datmon { get; set; }
        int id_datPhong { get; set; }
        int id_mon { get; set; }
        int soLuong { get; set; }
        DateTime thoiGianDat { get; set; }

        public DatMonModel(int id_datmon, int id_datPhong, int id_mon, int soLuong, DateTime thoiGianDat)
        {
            this.id_datmon = id_datmon;
            this.id_datPhong = id_datPhong;
            this.id_mon = id_mon;
            this.soLuong = soLuong;
            this.thoiGianDat = thoiGianDat;
        }
    }
}
