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
    class CtrOrderFood
    {
        private ConnectSql connectSql;
        public CtrOrderFood()
        {
            connectSql = new ConnectSql();
        }
        public DataTable getOrderById(string id_order)
        {
            SqlCommand cmd = new SqlCommand
         ("select Food.id_food,Food.picture,Food.name_food," +
         "OrderFood.amount,OrderFood.day_order,Food.price from OrderFood,Food " +
         "where id_order = @id_order and Food.id_food = OrderFood.id_food", connectSql.connection);
            cmd.Parameters.Add("@id_order", SqlDbType.Char).Value = id_order;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }
        public DataTable getDataOrderFood()
        {
            SqlCommand cmd = new SqlCommand
         ("select * from OrderFood", connectSql.connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }

        public bool insertOrderFood(OrderFood orderFood)
        {
            if (!new CtrCRUDFood().minusFood(orderFood.id_food, orderFood.amount)) return false;
            SqlCommand cmd = new SqlCommand("Insert into OrderFood Values" +
                "(@id_order,@id_food,@amount,@day_order)", connectSql.connection);
            cmd.Parameters.Add("@id_order", SqlDbType.Char).Value = orderFood.id_order;
            cmd.Parameters.Add("@id_food", SqlDbType.Char).Value = orderFood.id_food;
            cmd.Parameters.Add("@amount", SqlDbType.Int).Value = orderFood.amount;
            cmd.Parameters.Add("@day_order", SqlDbType.DateTime).Value = orderFood.day_order;
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
