using Management_Hotel.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management_Hotel.Control.ControlReceptionist
{
    public class CtrOrderRoom
    {
        private ConnectSql connectSql;
        public CtrOrderRoom()
        {
            connectSql = new ConnectSql();
        }
        public string hash_id_order(string id_room,int id_guest,DateTime day_order)
        {
            return id_room.Substring(0, 3) + id_guest.ToString() + day_order.Day.ToString();
        }
        public OrderRoom getOrderByIdRoom(string id_room)
        {
            DataTable data = this.getDataOrder();
            foreach(DataRow row in data.Rows)
            {
                if (row["id_room"].ToString().Trim() == id_room &&
                    row["status"].ToString().Trim()=="Open") 
                    return new OrderRoom(row.ItemArray);
            }
            return null;
        }
        public OrderRoom getOrderByIDOrder(string id_order)
        {
            DataTable data = this.getDataOrder();
            foreach (DataRow row in data.Rows)
            {
                if (row["id_order"].ToString().Trim() == id_order)
                    return new OrderRoom(row.ItemArray);
            }
            return null;
        }
        public DataTable getDataOrder()
        {
            SqlCommand cmd = new SqlCommand
         ("select * from OrderRoom", connectSql.connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }
        public DataTable getDataAvailableRoom()
        {
            SqlCommand cmd = new SqlCommand
                ("select Room.id_phong,Room.loai,Room.so_giuong,Room.vitri,Room.giaPhong " +
                "from Room inner join (Select Room.id_phong as id_room from Room " +
                "except " +
                "select OrderRoom.id_room from OrderRoom where status = 'Open') as available" +
                " on room.id_phong = available.id_room", connectSql.connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }
        public bool insertRoom(OrderRoom orderRoom)
        {
            SqlCommand cmd = new SqlCommand("Insert into OrderRoom Values" +
                "(@id_order,@id_room,@id_guest,@day_order,@status)", connectSql.connection);
            cmd.Parameters.Add("@id_order", SqlDbType.Char).Value = orderRoom.id_order;
            cmd.Parameters.Add("@id_room", SqlDbType.Char).Value = orderRoom.id_room;
            cmd.Parameters.Add("@id_guest", SqlDbType.Int).Value = orderRoom.id_guest;
            cmd.Parameters.Add("@day_order", SqlDbType.DateTime).Value = orderRoom.day_order;
            cmd.Parameters.Add("@status", SqlDbType.Char).Value = orderRoom.status ;
         
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
        public bool updatetRoom(OrderRoom orderRoom)
        {
            SqlCommand cmd = new SqlCommand("update OrderRoom set " +
                "id_room=@id_room,id_guest=@id_guest,day_order=@day_order," +
                "status=@status where id_order=@id_order",
                connectSql.connection);
            cmd.Parameters.Add("@id_order", SqlDbType.Char).Value = orderRoom.id_order;
            cmd.Parameters.Add("@id_room", SqlDbType.Char).Value = orderRoom.id_room;
            cmd.Parameters.Add("@id_guest", SqlDbType.Int).Value = orderRoom.id_guest;
            cmd.Parameters.Add("@day_order", SqlDbType.DateTime).Value = orderRoom.day_order;
            cmd.Parameters.Add("@status", SqlDbType.Char).Value = orderRoom.status;
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
        public bool closeRoom(string id_order)
        {
            SqlCommand cmd = new SqlCommand("update OrderRoom set " +
                "status=@status where id_order = @id_order",
    connectSql.connection);
            cmd.Parameters.Add("@id_order", SqlDbType.Char).Value = id_order;
            cmd.Parameters.Add("@Status", SqlDbType.Char).Value = "Close";

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
