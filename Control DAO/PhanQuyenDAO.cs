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
    public class PhanQuyenDAO
    {
        public static bool PhanQuyen_add_proc(string username,string tenQuyen,SqlTransaction trans)
        {
            SqlCommand cmd = new SqlCommand("EXEC  PhanQuyen_add_proc @username,@tenQuyen");
            cmd.Parameters.Add("@username", SqlDbType.Char).Value = username;
            cmd.Parameters.Add("@tenQuyen", SqlDbType.Char).Value = tenQuyen;
            if (trans != null)
            {
                cmd.Transaction = trans;
            }
            return ConnectionController.execute(cmd);
        }
        public static bool PhanQuyen_del_proc(string username, string tenQuyen, SqlTransaction trans)
        {
            SqlCommand cmd = new SqlCommand("EXEC  PhanQuyen_del_proc @username,@tenQuyen");
            cmd.Parameters.Add("@username", SqlDbType.Char).Value = username;
            cmd.Parameters.Add("@tenQuyen", SqlDbType.Char).Value = tenQuyen; 
            if (trans != null)
            {
                cmd.Transaction = trans;
            }
            return ConnectionController.execute(cmd);
        }
        public static DataTable PhanQuyen_detail_view()
        {
            SqlCommand cmd = new SqlCommand("select ID_PhanQuyen,Username,ID_nv,ChucVu,TenQuyen from PhanQuyen_detail_view");
            return ConnectionController.getData(cmd);
        }
        public static DataTable PhanQuyen_seachByIDNV_func(string  username)
        {
            SqlCommand cmd = new SqlCommand("select ID_PhanQuyen,Username,ID_nv,ChucVu,TenQuyen from PhanQuyen_seachByIDNV_func(@username)");
            cmd.Parameters.Add("@username", SqlDbType.Char).Value = username;
            return ConnectionController.getData(cmd);
        }
        public static DataTable PhanQuyen_seachByID_func(string username,string tenQuyen)
        {
            SqlCommand cmd = new SqlCommand("select ID_PhanQuyen,Username,ID_nv,ChucVu,TenQuyen from PhanQuyen_seachByID_func(@username,@tenQuyen)");
            cmd.Parameters.Add("@username", SqlDbType.Char).Value = username;
            cmd.Parameters.Add("@tenQuyen", SqlDbType.Char).Value = tenQuyen;
            return ConnectionController.getData(cmd);
        }
    }
}
