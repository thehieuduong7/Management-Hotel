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
    public class ThanhToanDAO
    {
        public static bool ThanhToan_add_proc(int id_datphong, int id_nvthanhtoan,SqlTransaction trans)
        {
            SqlCommand cmd = new SqlCommand("EXEC  ThanhToan_add_proc @ID_DatPhong,@ID_NVThanhToan");
            cmd.Parameters.Add("@ID_DatPhong", SqlDbType.Int).Value = id_datphong;
            cmd.Parameters.Add("@ID_NVThanhToan", SqlDbType.Int).Value = id_nvthanhtoan;
            if (trans != null)
            {
                cmd.Transaction = trans;
            }
            return ConnectionController.execute(cmd);
        }
        public static DataTable ThanhToan_detail_view()
        {
            SqlCommand cmd = new SqlCommand("select ID_ThanhToan,ID_DatPhong,TenKH," +
                "TenPhong,TenNVTT,TongTien,ThoiGianThanhToan from ThanhToan_detail_view");
            return ConnectionController.getData(cmd);
        }

        public static DataTable ThanhToan_TongTienPhong_func(int madat)
        {
            SqlCommand cmd = new SqlCommand("select dbo.NhapKho_searchByID_func(@MaDat)");
            cmd.Parameters.Add("@MaDat", SqlDbType.Int).Value = madat;
            return ConnectionController.getData(cmd);
        }
    }
}
