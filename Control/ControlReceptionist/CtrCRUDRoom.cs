using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Management_Hotel.Model;
namespace Management_Hotel.Control.ControlReceptionist
{
    public class CtrCRUDRoom
    {
        private ConnectSql connectSql;
        public CtrCRUDRoom()
        {
            connectSql = new ConnectSql();
        }
        public DataTable getStaticRoom()
        {
            SqlCommand cmd = new SqlCommand("Select loai,count(*) from Room " +
                "group by loai", connectSql.connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }
        public bool isExistingID(string id_room)
        {
            if (id_room.Length == 0) return true;
            DataTable data = getDataRoom();
            foreach(DataRow row in data.Rows)
            {
                if (row[0].ToString().Trim() == id_room)
                {
                    return true;
                }
            }
            return false;
        }
        public string get_state_room(string id_room)
        {
            SqlCommand cmd = new SqlCommand("Select * from OrderRoom where " +
                "id_room=@id_room and status = 'Open'", connectSql.connection);
            cmd.Parameters.Add("@id_room", SqlDbType.Char).Value = id_room;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable data = new DataTable();
            adapter.Fill(data);
            return (data.Rows.Count == 0) ? "Closed" : "Open";
        }
        public Room getRoomById(string id_room)
        {
            DataTable data = getDataRoom();
            foreach(DataRow row in data.Rows)
            {
                if (row[0].ToString().Trim() == id_room.Trim())
                {
                    return new Room(row.ItemArray);
                }
            }
            return null;
        }
        public DataTable getDataRoom()
        {
            SqlCommand cmd = new SqlCommand("Select * from Room", connectSql.connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }
        public bool insertRoom(Room room)
        {
            SqlCommand cmd = new SqlCommand("Insert into Room Values(@id_phong,@loai,@so_giuong," +
                "@vitri,@giaPhong)", connectSql.connection);
            cmd.Parameters.Add("@id_phong", SqlDbType.Char).Value = room.id_phong;
            cmd.Parameters.Add("@loai", SqlDbType.Char).Value = room.loai;
            cmd.Parameters.Add("@so_giuong", SqlDbType.Int).Value = room.so_giuong;
            cmd.Parameters.Add("@vitri", SqlDbType.Char).Value = room.vitri;
            cmd.Parameters.Add("@giaPhong", SqlDbType.Float).Value = room.giaPhong;
            connectSql.open();
            bool result = false;
            try
            {
                result = (cmd.ExecuteNonQuery() == 1);
            }
            catch (SqlException)
            {
                return false;
            }
            finally
            {
                connectSql.close();
            }
            return result;
        }
        public bool updatetRoom(Room room)
        {
            SqlCommand cmd = new SqlCommand("update Room set " +
                "loai=@loai,so_giuong=@so_giuong,vitri=@vitri,giaPhong=@giaPhong where id_phong=@id_phong", 
                connectSql.connection);
            cmd.Parameters.Add("@id_phong", SqlDbType.Char).Value = room.id_phong;
            cmd.Parameters.Add("@loai", SqlDbType.Char).Value = room.loai;
            cmd.Parameters.Add("@so_giuong", SqlDbType.Int).Value = room.so_giuong;
            cmd.Parameters.Add("@vitri", SqlDbType.Char).Value = room.vitri;
            cmd.Parameters.Add("@giaPhong", SqlDbType.Float).Value = room.giaPhong;
            connectSql.open();
            bool result = false;
            try
            {
                result = (cmd.ExecuteNonQuery() == 1);
            }
            catch (SqlException)
            {
                return false;
            }
            finally
            {
                connectSql.close();
            }
            return result;
        }
        public bool removeRoom(string id_phong)
        {
            SqlCommand cmd = new SqlCommand("delete from Room where id_phong=@id_phong",
    connectSql.connection);
            cmd.Parameters.Add("@id_phong", SqlDbType.Char).Value = id_phong;
            connectSql.open();
            bool result = false;
            try
            {
                result = (cmd.ExecuteNonQuery() == 1);
            }
            catch (SqlException)
            {
                return false;
            }
            finally
            {
                connectSql.close();
            }
            return result;
        }
    }
}
