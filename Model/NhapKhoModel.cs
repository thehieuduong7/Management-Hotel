using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management_Hotel.Model
{
    class NhapKhoModel
    {
        int id_nhapKho { get; set; }
        int id_mon { get; set; }
        int soLuong { get; set; }
        int id_nvNhap { get; set; }
        DateTime thoiGianNhap { get; set; }

        public NhapKhoModel(int id_nhapKho, int id_mon, int soLuong, int id_nvNhap, DateTime thoiGianNhap)
        {
            this.id_nhapKho = id_nhapKho;
            this.id_mon = id_mon;
            this.soLuong = soLuong;
            this.id_nvNhap = id_nvNhap;
            this.thoiGianNhap = thoiGianNhap;
        }
    }
}
