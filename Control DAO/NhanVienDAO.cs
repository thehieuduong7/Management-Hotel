using Management_Hotel.Control;
using Management_Hotel.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management_Hotel.Control_DAO
{
    class NhanVienDAO
    {
        public bool insert(NhanVienModel nv)
        {
            SqlCommand cmd = new SqlCommand("EXEC  NhanVien_add_proc @Ho,@Ten,@NgaySinh,@SDT,@GioiTinh,@Avatar");
            cmd.Parameters.Add("@Ho", SqlDbType.Int).Value = kh.Ho;
            return ConnectionController.execute(cmd);
        }
        public bool UpdateFull(NhanVienModel kh)
        {
            SqlCommand cmd = new SqlCommand("");
            cmd.Parameters.Add("@Ho", SqlDbType.Int).Value = kh.Ho;
            return ConnectionController.execute(cmd);
        }
        public bool UpdateNotFull(NhanVienModel kh)
        {
            SqlCommand cmd = new SqlCommand("");
            cmd.Parameters.Add("@Ho", SqlDbType.Int).Value = kh.Ho;
            return ConnectionController.execute(cmd);
        }
        public bool Delete(NhanVienModel kh)
        {
            SqlCommand cmd = new SqlCommand("");
            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = kh.id_kh;
            return ConnectionController.execute(cmd);
        }
    }
}
