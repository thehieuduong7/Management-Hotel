using Management_Hotel.Control;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management_Hotel.Control_DAO
{
    public class PhongDAO
    {
        public static bool Phong_add_proc(String tenphong, String vitri, Image photo, float gia,SqlTransaction trans)
        {
            SqlCommand cmd = new SqlCommand("EXEC  Phong_add_proc @TenPhong,@Vitri,@Photo,@Gia");
            cmd.Parameters.Add("@TenPhong", SqlDbType.Char).Value = tenphong;
            cmd.Parameters.Add("@Vitri", SqlDbType.Char).Value = vitri;
            cmd.Parameters.Add("@Photo", SqlDbType.Image).Value = GlobalUser.cvtToByte(photo);
            cmd.Parameters.Add("@Gia", SqlDbType.Float).Value = gia;
            if (trans != null)
            {
                cmd.Transaction = trans;
            }
            return ConnectionController.execute(cmd);
        }
        public static bool Phong_del_proc(int idp,SqlTransaction trans)
        {
            SqlCommand cmd = new SqlCommand("EXEC  Phong_del_proc @id");
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = idp;
            if (trans != null)
            {
                cmd.Transaction = trans;
            }
            return ConnectionController.execute(cmd);
        }
        public static bool Phong_upd_sort_proc(int id, String tenphong, String vitri, Image photo,SqlTransaction trans)
        {
            SqlCommand cmd = new SqlCommand("EXEC  Phong_upd_sort_proc @ID,@TenPhong,@Vitri,@Photo");
            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@TenPhong", SqlDbType.Char).Value = tenphong;
            cmd.Parameters.Add("@Vitri", SqlDbType.Char).Value = vitri;
            cmd.Parameters.Add("@Photo", SqlDbType.Image).Value = GlobalUser.cvtToByte(photo);
            if (trans != null)
            {
                cmd.Transaction = trans;
            }
            return ConnectionController.execute(cmd);
        }
        public static bool Phong_upd_full_proc(int id, String tenphong, String vitri, Image photo, float gia,SqlTransaction trans)
        {
            SqlCommand cmd = new SqlCommand("EXEC  Phong_upd_full_proc @ID,@TenPhong,@Vitri,@Photo,@Gia");
            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@TenPhong", SqlDbType.Char).Value = tenphong;
            cmd.Parameters.Add("@Vitri", SqlDbType.Char).Value = vitri;
            cmd.Parameters.Add("@Photo", SqlDbType.Image).Value = GlobalUser.cvtToByte(photo);
            cmd.Parameters.Add("@Gia", SqlDbType.Float).Value = gia;
            if (trans != null)
            {
                cmd.Transaction = trans;
            }
            return ConnectionController.execute(cmd);
        }

        public static DataTable Phong_trangthai_view()
        {
            SqlCommand cmd = new SqlCommand("select ID_Phong,TenPhong,Vitri,Photo,Gia,TrangThai from Phong_trangthai_view");
            return ConnectionController.getData(cmd);
        }
        public static DataTable Phong_Available_view()
        {
            SqlCommand cmd = new SqlCommand("select ID_Phong,TenPhong,Vitri,Photo,Gia,TrangThai from Phong_Available_view");
            return ConnectionController.getData(cmd);
        }
        public static DataTable Phong_searchByID_func(int ID_Phong)
        {
            SqlCommand cmd = new SqlCommand("select ID_Phong,TenPhong,Vitri,Photo,Gia,TrangThai from Phong_searchByID_func(@ID_Phong)");
            cmd.Parameters.Add("@ID_Phong", SqlDbType.Int).Value = ID_Phong;
            return ConnectionController.getData(cmd);
        }
        public static DataTable Phong_searchFilter_func(String TenPhong)
        {
            SqlCommand cmd = new SqlCommand("select ID_Phong,TenPhong,Vitri,Photo,Gia,TrangThai from Phong_searchFilter_func(@TenPhong)");
            cmd.Parameters.Add("@TenPhong", SqlDbType.Char).Value = TenPhong;
            return ConnectionController.getData(cmd);
        }
    }
}
