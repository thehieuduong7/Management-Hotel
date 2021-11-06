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
    public class KhachHangDAO
    {
        public KhachHangModel getKhachHangtByID(int id_guest)
        {
   
        }
        public DataTable getData()
        {
            SqlCommand cmd = new SqlCommand("");
            return ConnectionController.getData(cmd);
        }
        public bool insert(KhachHangModel kh)
        {
            SqlCommand cmd = new SqlCommand("EXEC  KhachHang_add_proc @Ho,@Ten,@NgaySinh,@SDT,@GioiTinh,@Avatar");
            cmd.Parameters.Add("@Ho", SqlDbType.Int).Value = kh.Ho;
            cmd.Parameters.Add("@Ten", SqlDbType.Char).Value = kh.Ten;
            cmd.Parameters.Add("@NgaySinh", SqlDbType.Date).Value = kh.NgaySinh.ToShortDateString();
            cmd.Parameters.Add("@SDT", SqlDbType.Char).Value = kh.SDT;
            cmd.Parameters.Add("@GioiTinh", SqlDbType.Char).Value = kh.GioiTinh;
            cmd.Parameters.Add("@Avatar", SqlDbType.Image).Value = kh.cvtToByte(kh.Avatar);
            return ConnectionController.execute(cmd);
        }
        public bool Update(KhachHangModel kh)
        {
            SqlCommand cmd = new SqlCommand("");
            cmd.Parameters.Add("@Ho", SqlDbType.Int).Value = kh.Ho;
            cmd.Parameters.Add("@Ten", SqlDbType.Char).Value = kh.Ten;
            cmd.Parameters.Add("@NgaySinh", SqlDbType.Date).Value = kh.NgaySinh.ToShortDateString();
            cmd.Parameters.Add("@SDT", SqlDbType.Char).Value = kh.SDT;
            cmd.Parameters.Add("@GioiTinh", SqlDbType.Char).Value = kh.GioiTinh;
            cmd.Parameters.Add("@Avatar", SqlDbType.Image).Value = kh.cvtToByte(kh.Avatar);
            return ConnectionController.execute(cmd);
        }
        public bool Delete(KhachHangModel kh)
        {
            SqlCommand cmd = new SqlCommand("");
            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = kh.id_kh;
            return ConnectionController.execute(cmd);
        }
    }
}
