using Management_Hotel.Control;
using Management_Hotel.Model;
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
    class NhanVienDAO
    {
        public static bool NhanVien_add_proc(String ho, String ten, DateTime NgaySinh, String std, String gioitinh,Image  avatar, float luong, String chucvu,SqlTransaction trans)
        {
            SqlCommand cmd = new SqlCommand("EXEC  NhanVien_add_proc @Ho,@Ten,@NgaySinh,@SDT,@GioiTinh,@Avatar,@Luong,@ChucVu");
            cmd.Parameters.Add("@Ho", SqlDbType.Char).Value = ho;
            cmd.Parameters.Add("@Ten", SqlDbType.Char).Value = ten;
            cmd.Parameters.Add("@NgaySinh", SqlDbType.Date).Value = NgaySinh.ToShortDateString();
            cmd.Parameters.Add("@SDT", SqlDbType.Char).Value = std;
            cmd.Parameters.Add("@GioiTinh", SqlDbType.Char).Value = gioitinh;
            cmd.Parameters.Add("@Avatar", SqlDbType.Image).Value = GlobalUser.cvtToByte(avatar);
            cmd.Parameters.Add("@Luong", SqlDbType.Float).Value = luong;
            cmd.Parameters.Add("@ChucVu", SqlDbType.Char).Value = chucvu;
            if (trans != null)
            {
                cmd.Transaction = trans;
            }
            return ConnectionController.execute(cmd);
        }
        public static bool NhanVien_del_proc(int idnv,SqlTransaction trans)
        {
            SqlCommand cmd = new SqlCommand("EXEC  NhanVien_del_proc @id");
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = idnv;
            if (trans != null)
            {
                cmd.Transaction = trans;
            }
            return ConnectionController.execute(cmd);
        }
        public static bool NhanVien_upd_sort_proc(int id, String ho, String ten, DateTime NgaySinh, String std, String gioitinh, Image avatar, float luong, String chucvu,SqlTransaction trans)
        {
            SqlCommand cmd = new SqlCommand("EXEC  NhanVien_upd_sort_proc @ID,@Ho,@Ten,@NgaySinh,@SDT,@GioiTinh,@Avatar,@Luong,@ChucVu");
            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@Ho", SqlDbType.Char).Value = ho;
            cmd.Parameters.Add("@Ten", SqlDbType.Char).Value = ten;
            cmd.Parameters.Add("@NgaySinh", SqlDbType.Date).Value = NgaySinh.ToShortDateString();
            cmd.Parameters.Add("@SDT", SqlDbType.Char).Value = std;
            cmd.Parameters.Add("@GioiTinh", SqlDbType.Char).Value = gioitinh;
            cmd.Parameters.Add("@Avatar", SqlDbType.Image).Value = GlobalUser.cvtToByte(avatar);
            cmd.Parameters.Add("@GioiTinh", SqlDbType.Float).Value = luong;
            cmd.Parameters.Add("@ChucVu", SqlDbType.Char).Value = chucvu;
            if (trans != null)
            {
                cmd.Transaction = trans;
            }
            return ConnectionController.execute(cmd);
        }
        public static bool NhanVien_upd_full_proc(int id, String ho, String ten, DateTime NgaySinh, String std, String gioitinh, Image avatar, float luong, String chucvu, SqlTransaction trans)
        {
            SqlCommand cmd = new SqlCommand("EXEC  NhanVien_upd_full_proc @ID,@Ho,@Ten,@NgaySinh,@SDT,@GioiTinh,@Avatar,@Luong,@ChucVu");
            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@Ho", SqlDbType.Char).Value = ho;
            cmd.Parameters.Add("@Ten", SqlDbType.Char).Value = ten;
            cmd.Parameters.Add("@NgaySinh", SqlDbType.Date).Value = NgaySinh.ToShortDateString();
            cmd.Parameters.Add("@SDT", SqlDbType.Char).Value = std;
            cmd.Parameters.Add("@GioiTinh", SqlDbType.Char).Value = gioitinh;
            cmd.Parameters.Add("@Avatar", SqlDbType.Image).Value = GlobalUser.cvtToByte(avatar);
            cmd.Parameters.Add("@Luong", SqlDbType.Float).Value = luong;
            cmd.Parameters.Add("@ChucVu", SqlDbType.Char).Value = chucvu;
            if (trans != null)
            {
                cmd.Transaction = trans;
            }
            return ConnectionController.execute(cmd);
        }
        public static DataTable NhanVien_detail_view()
        {
            SqlCommand cmd = new SqlCommand("select ID_NV,Ho,Ten,NgaySinh,SDT,GioiTinh,Avatar," +
                "Luong,ChucVu from NhanVien_detail_view");
            return ConnectionController.getData(cmd);
        }
        public static DataTable NhanVien_searchByID_func(int id)
        {
            SqlCommand cmd = new SqlCommand("select ID_NV,Ho,Ten,NgaySinh,SDT,GioiTinh,Avatar,Luong,ChucVu" +
                " from NhanVien_searchByID_func(@id)");
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            return ConnectionController.getData(cmd);
        }
        public static DataTable NhanVien_searchFilter_func(String name)
        {
            SqlCommand cmd = new SqlCommand("select ID_NV,Ho,Ten,NgaySinh,SDT," +
                "GioiTinh,Avatar,Luong,ChucVu from NhanVien_searchFilter_func(@name)");
            cmd.Parameters.Add("@name", SqlDbType.Char).Value = name;
            return ConnectionController.getData(cmd);
        }
        public static DataTable NhanVien_lastestID_func()
        {
            SqlCommand cmd = new SqlCommand("select top 1 ID_NV from NhanVien_detail_view decs");
            return ConnectionController.getData(cmd);
        }
    }
}
