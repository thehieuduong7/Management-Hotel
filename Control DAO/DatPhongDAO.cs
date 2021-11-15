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
    public class DatPhongDAO
    {
 
        public static bool DatPhong_add_proc(int idkh, int idp, int idnv,SqlTransaction trans)
        {
            SqlCommand cmd = new SqlCommand("EXEC  DatPhong_add_proc @ID_KH,@ID_PHONG,@ID_NV");
            cmd.Parameters.Add("@ID_KH", SqlDbType.Int).Value = idkh;
            cmd.Parameters.Add("@ID_PHONG", SqlDbType.Int).Value = idp;
            cmd.Parameters.Add("@ID_NV", SqlDbType.Int).Value = idnv;
            if (trans != null)
            {
                cmd.Transaction = trans;
            }
            return ConnectionController.execute(cmd);
        }
        public static bool DatPhong_doiPhong_proc(int madat, int idp,SqlTransaction trans)
        {
            SqlCommand cmd = new SqlCommand("EXEC  DatPhong_doiPhong_proc @MaDat,@ID_PHONG");
            cmd.Parameters.Add("@MaDat", SqlDbType.Int).Value = madat;
            cmd.Parameters.Add("@ID_PHONG", SqlDbType.Int).Value = idp;
            if (trans != null)
            {
                cmd.Transaction = trans;
            }
            return ConnectionController.execute(cmd);
        }
        public static DataTable DatPhong_detail_view()
        {
            SqlCommand cmd = new SqlCommand("select MaDat,ID_KH,TenKhachHang,ID_Phong," +
                "TenPhong,GiaPhong,ID_NV,TenNVDat, NgayDat, TrangThai from DatPhong_detail_view");
            return ConnectionController.getData(cmd);
        }
        public static DataTable DatPhong_TongTienDatPhong_func(int madat)
        {
            SqlCommand cmd = new SqlCommand("select dbo.DatPhong_TongTienDatPhong_func(@MaDat)");
            cmd.Parameters.Add("@MaDat", SqlDbType.Int).Value = madat;
            return ConnectionController.getData(cmd);
        }
        public static DataTable DatPhong_search_func(int madat)
        {
            SqlCommand cmd = new SqlCommand("select MaDat,ID_KH,TenKhachHang,ID_Phong," +
                "TenPhong,GiaPhong,ID_NV,TenNVDat, NgayDat, TrangThai from  dbo.DatPhong_search_func(@MaDat)");
            cmd.Parameters.Add("@MaDat", SqlDbType.Int).Value = madat;
            return ConnectionController.getData(cmd);
        }
        public static DataTable DatPhong_getMaDatAvaiByIDPhong_func(int idp)
        {
            SqlCommand cmd = new SqlCommand("select  dbo.DatPhong_getMaDatAvaiByIDPhong_func(@ID_Phong)");
            cmd.Parameters.Add("@ID_Phong", SqlDbType.Int).Value = idp;
            return ConnectionController.getData(cmd);
        }
    }
}
