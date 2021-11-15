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
    public class AccountNVDAO
    {
        public static bool AccountNV_add_proc(String username, String password, int idnv,SqlTransaction trans)
        {
            SqlCommand cmd = new SqlCommand("EXEC  AccountNV_add_proc @User,@Pass,@ID");
            cmd.Parameters.Add("@User", SqlDbType.Char).Value = username;
            cmd.Parameters.Add("@Pass", SqlDbType.Char).Value = password;
            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = idnv;
            if (trans != null)
            {
                cmd.Transaction = trans;
            }
            return ConnectionController.execute(cmd);
        }
        public static bool AccountNV_del_proc(String username,SqlTransaction trans)
        {
            SqlCommand cmd = new SqlCommand("EXEC  AccountNV_del_proc @User");
            cmd.Parameters.Add("@User", SqlDbType.Char).Value = username;
            if (trans != null)
            {
                cmd.Transaction = trans;
            }
            return ConnectionController.execute(cmd);
        }
        public static bool AccountNV_upd_proc(String username, String password,SqlTransaction trans)
        {
            SqlCommand cmd = new SqlCommand("EXEC  AccountNV_upd_proc @User,@Pass");
            cmd.Parameters.Add("@User", SqlDbType.Char).Value = username;
            cmd.Parameters.Add("@Pass", SqlDbType.Char).Value = password;
            if (trans != null)
            {
                cmd.Transaction = trans;
            }
            return ConnectionController.execute(cmd);
        }
        public static DataTable AccountNV_detail_view()
        {
            SqlCommand cmd = new SqlCommand("select Username,Password,ID_NV,TenNV,ChucVU from AccountNV_detail_view");
            return ConnectionController.getData(cmd);
        }
        public static DataTable AccountNV_login_func(String username,String password)
        {
            SqlCommand cmd = new SqlCommand("select Username,Password,ID_NV,TenNV,ChucVU from AccountNV_login_func(@username,@password)");
            cmd.Parameters.Add("@username", SqlDbType.Char).Value = username;
            cmd.Parameters.Add("@password", SqlDbType.Char).Value = password;
            return ConnectionController.getData(cmd);
        }
    }
}
