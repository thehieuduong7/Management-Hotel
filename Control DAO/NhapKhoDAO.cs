using Management_Hotel.Control;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management_Hotel.Control_DAO
{
    public class NhapKhoDAO
    {
        public static bool NhapKho_add_proc(int idmon, int soluong, int id_nvnhap,SqlTransaction trans)
        {
            SqlCommand cmd = new SqlCommand("EXEC NhapKho_add_proc @ID_Mon,@SoLuong,@ID_NVNhap");
            cmd.Parameters.Add("@ID_Mon", SqlDbType.Int).Value = idmon;
            cmd.Parameters.Add("@SoLuong", SqlDbType.Int).Value = soluong;
            cmd.Parameters.Add("@ID_NVNhap", SqlDbType.Int).Value = id_nvnhap;
            if (trans != null)
            {
                cmd.Transaction = trans;
            }
            return ConnectionController.execute(cmd);
        }
        public static DataTable NhapKho_TongNhap_view()
        {
            SqlCommand cmd = new SqlCommand("select ID_Mon,TenMon,TongSoLuongDaNhap," +
                "GiaGoc,GiaBan,Photo from NhapKho_TongNhap_view");
            return ConnectionController.getData(cmd);
        }
        public static DataTable NhapKho_detail_view()
        {
            SqlCommand cmd = new SqlCommand("select ID_NhapKho,ID_Mon,TenMon," +
                "SoluongNhap,GiaGoc,GiaBan,Photo,ThoiGianNhap from NhapKho_detail_view");
            return ConnectionController.getData(cmd);
        }

        public static DataTable NhapKho_searchByID_func(int mon)
        {
            SqlCommand cmd = new SqlCommand("select ID_NhapKho,ID_Mon,TenMon,SoluongNhap," +
                "GiaGoc,GiaBan,Photo,ThoiGianNhap from  dbo.NhapKho_searchByID_func(@Mon)");
            cmd.Parameters.Add("@Mon", SqlDbType.Int).Value = mon;
            return ConnectionController.getData(cmd);
        }

        
    }
}
