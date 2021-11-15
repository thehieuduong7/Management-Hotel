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
    public class KhoDAO
    {
        public static bool Kho_add_proc(String tenmon, int soluong, float giagoc, float giaban, Image photo,SqlTransaction trans)
        {
            SqlCommand cmd = new SqlCommand("EXEC  Kho_add_proc @TenMon,@SoLuong,@GiaGoc,@GiaBan,@Photo");
            cmd.Parameters.Add("@TenMon", SqlDbType.Char).Value = tenmon;
            cmd.Parameters.Add("@SoLuong", SqlDbType.Char).Value = soluong;
            cmd.Parameters.Add("@GiaGoc", SqlDbType.Char).Value = giagoc;
            cmd.Parameters.Add("@GiaBan", SqlDbType.Char).Value = giaban;
            cmd.Parameters.Add("@Photo", SqlDbType.Image).Value = GlobalUser.cvtToByte(photo);
            if (trans != null)
            {
                cmd.Transaction = trans;
            }
            return ConnectionController.execute(cmd);
        }
        public static bool Kho_del_proc(int idm,SqlTransaction trans)
        {
            SqlCommand cmd = new SqlCommand("EXEC  Kho_del_proc @ID_Mon");
            cmd.Parameters.Add("@ID_Mon", SqlDbType.Int).Value = idm;
            if (trans != null)
            {
                cmd.Transaction = trans;
            }
            return ConnectionController.execute(cmd);
        }
        public static bool Kho_upd_proc(int idm, String tenmon, int soluong, float giagoc, float giaban, Image photo,SqlTransaction trans)
        {
            SqlCommand cmd = new SqlCommand("EXEC  Kho_upd_proc @ID,@TenMon,@SoLuong,@GiaGoc,@GiaBan,@Photo");
            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = idm;
            cmd.Parameters.Add("@TenMon", SqlDbType.Char).Value = tenmon;
            cmd.Parameters.Add("@SoLuong", SqlDbType.Int).Value = soluong;
            cmd.Parameters.Add("@GiaGoc", SqlDbType.Float).Value = giagoc;
            cmd.Parameters.Add("@GiaBan", SqlDbType.Float).Value = giaban;
            cmd.Parameters.Add("@Photo", SqlDbType.Image).Value = GlobalUser.cvtToByte(photo);
            if (trans != null)
            {
                cmd.Transaction = trans;
            }
            return ConnectionController.execute(cmd);
        }
        public static DataTable Kho_detail_view()
        {
            SqlCommand cmd = new SqlCommand("select ID_Mon,TenMon,SoLuong,GiaGoc,GiaBan,Photo" +
                " from Kho_detail_view");
            return ConnectionController.getData(cmd);
        }
        public static DataTable Kho_Available_view()
        {
            SqlCommand cmd = new SqlCommand("select ID_Mon,TenMon,SoLuong,GiaGoc,GiaBan,Photo from Kho_Available_view");
            return ConnectionController.getData(cmd);
        }
        public static DataTable Kho_searchByID_func(int idm)
        {
            SqlCommand cmd = new SqlCommand("select ID_Mon,TenMon,SoLuong,GiaGoc,GiaBan,Photo" +
                " from  dbo.Kho_searchByID_func(@ID_Mon)");
            cmd.Parameters.Add("@ID_Mon", SqlDbType.Int).Value = idm;
            return ConnectionController.getData(cmd);
        }
        public static DataTable Kho_searchFilter_func(String name)
        {
            SqlCommand cmd = new SqlCommand("select ID_Mon,TenMon,SoLuong,GiaGoc,GiaBan,Photo" +
                " from  dbo.Kho_searchFilter_func(@Name)");
            cmd.Parameters.Add("@Name", SqlDbType.Char).Value = name;
            return ConnectionController.getData(cmd);
        }
    }
}
