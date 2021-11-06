using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management_Hotel.Model
{
    class ThanhToanModel
    {
        int id_thanhToan { get; set; }
        int id_datPhong { get; set; }
        int id_nvThanhToan { get; set; }
        float TongTien { get; set; }
        DateTime ThoiGianThanhToan { get; set; }

        public ThanhToanModel(int id_thanhToan, int id_datPhong, int id_nvThanhToan, float tongTien, DateTime thoiGianThanhToan)
        {
            this.id_thanhToan = id_thanhToan;
            this.id_datPhong = id_datPhong;
            this.id_nvThanhToan = id_nvThanhToan;
            TongTien = tongTien;
            ThoiGianThanhToan = thoiGianThanhToan;
        }
    }
}
