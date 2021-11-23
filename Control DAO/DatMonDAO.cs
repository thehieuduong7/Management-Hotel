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
    public class DatMonDAO
    {
        public static bool DatMon_add_proc(int id_datphong, int id_mon, int soluong,SqlTransaction trans)
        {
            SqlCommand cmd = new SqlCommand("EXEC  DatMon_add_proc @ID_DatPhong,@ID_Mon,@SoLuong");
            cmd.Parameters.Add("@ID_DatPhong", SqlDbType.Int).Value = id_datphong;
            cmd.Parameters.Add("@ID_Mon", SqlDbType.Int).Value = id_mon;
            cmd.Parameters.Add("@SoLuong", SqlDbType.Int).Value = soluong;
            if (trans != null)
            {
                cmd.Transaction = trans;
            }
            return ConnectionController.execute(cmd);
        }
        public static DataTable DatMon_detail_view()
        {
            SqlCommand cmd = 
                new SqlCommand("select ID_DatMon,MaDat,TenKH,TenPhong,TenMon,GiaMon,SoLuong,ThoiGianDat from DatMon_detail_view");
            return ConnectionController.getData(cmd);
        }

        public static DataTable DatMon_listDaDat_func(int madat)
        {
            SqlCommand cmd = new SqlCommand("select ID_DatMon,ID_Mon,TenMon,GiaBan,SoLuong,TongTien,ThoiGianDat" +
                " from  dbo.DatMon_listDaDat_func(@MaDat)");
            cmd.Parameters.Add("@MaDat", SqlDbType.Int).Value = madat;
            return ConnectionController.getData(cmd);
        }
        public static DataTable DatMon_tongTienDatMon_func(int madat)
        {
            SqlCommand cmd = new SqlCommand("select dbo.DatMon_tongTienDatMon_func(@MaDat)");
            cmd.Parameters.Add("@MaDat", SqlDbType.Int).Value = madat;
            return ConnectionController.getData(cmd);
        }

    }
}
