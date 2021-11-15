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
    public class KhachHangDAO
    {
        public static bool KhachHang_add_proc(String ho, String ten, DateTime NgaySinh, String sdt, String gioitinh, Image avatar,SqlTransaction trans)
        {
            SqlCommand cmd = new SqlCommand("EXEC  KhachHang_add_proc @Ho,@Ten,@NgaySinh,@SDT,@GioiTinh,@Avatar");
            cmd.Parameters.Add("@Ho", SqlDbType.Char).Value = ho;
            cmd.Parameters.Add("@Ten", SqlDbType.Char).Value = ten;
            cmd.Parameters.Add("@NgaySinh", SqlDbType.Date).Value = NgaySinh.ToShortDateString();
            cmd.Parameters.Add("@SDT", SqlDbType.Char).Value = sdt;
            cmd.Parameters.Add("@GioiTinh", SqlDbType.Char).Value = gioitinh;
            cmd.Parameters.Add("@Avatar", SqlDbType.Image).Value = GlobalUser.cvtToByte(avatar);
            if (trans != null)
            {
                cmd.Transaction = trans;
            }
            return ConnectionController.execute(cmd);
        }
        public static bool KhachHang_del_proc(int idkh,SqlTransaction trans)
        {
            SqlCommand cmd = new SqlCommand("EXEC  KhachHang_del_proc @id");
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = idkh;
            if (trans != null)
            {
                cmd.Transaction = trans;
            }
            return ConnectionController.execute(cmd);
        }
        public static bool KhachHang_upd_proc(int ID_KH, String ho, String ten, DateTime NgaySinh, String sdt, String gioitinh, Image avatar,SqlTransaction trans)
        {
            SqlCommand cmd = new SqlCommand("EXEC  KhachHang_upd_proc @ID_KH,@Ho,@Ten,@NgaySinh,@SDT,@GioiTinh,@Avatar");
            cmd.Parameters.Add("@ID_KH", SqlDbType.Int).Value = ID_KH;
            cmd.Parameters.Add("@Ho", SqlDbType.Char).Value = ho;
            cmd.Parameters.Add("@Ten", SqlDbType.Char).Value = ten;
            cmd.Parameters.Add("@NgaySinh", SqlDbType.Date).Value = NgaySinh.ToShortDateString();
            cmd.Parameters.Add("@SDT", SqlDbType.Char).Value = sdt;
            cmd.Parameters.Add("@GioiTinh", SqlDbType.Char).Value = gioitinh;
            cmd.Parameters.Add("@Avatar", SqlDbType.Image).Value = GlobalUser.cvtToByte(avatar);
            if (trans != null)
            {
                cmd.Transaction = trans;
            }
            return ConnectionController.execute(cmd);
        }
        public static DataTable KhachHang_detail_view()
        {
            SqlCommand cmd = 
                new SqlCommand("select ID_KH,Ho,Ten,NgaySinh,SDT,GioiTinh,Avatar from KhachHang_detail_view");
            return ConnectionController.getData(cmd);
        }
        public static DataTable KhachHang_searchByID_func(int ID_KH)
        {
            SqlCommand cmd = new SqlCommand("select ID_KH,Ho,Ten,NgaySinh,SDT,GioiTinh,Avatar" +
                " from KhachHang_searchByID_func(@ID_KH)");
            cmd.Parameters.Add("@ID_KH", SqlDbType.Int).Value = ID_KH;
            return ConnectionController.getData(cmd);
        }
        public static DataTable KhachHang_searchFilter_func(String name)
        {
            SqlCommand cmd = new SqlCommand("select ID_KH,Ho,Ten,NgaySinh,SDT,GioiTinh,Avatar" +
                " from KhachHang_searchFilter_func(@name)");
            cmd.Parameters.Add("@name", SqlDbType.Char).Value = name;
            return ConnectionController.getData(cmd);
        }
    }
}
