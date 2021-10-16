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
    public class CtrCRUDFood
    {
        ConnectSql connectSql;
        public CtrCRUDFood()
        {
            this.connectSql = new ConnectSql();
        }
        public Food getFoodByID(int id_food)
        {
            DataTable data = getDataFood();
            foreach (DataRow row in data.Rows)
            {
                if (int.Parse(row[0].ToString()) == id_food)
                    return new Food(row.ItemArray);
            }
            return null;
        }
        public int getAmount(string id_food)
        {
            DataTable data = getDataFood();
            foreach (DataRow row in data.Rows)
            {
                if (row[0].ToString().Trim() == id_food)
                    return int.Parse(row["Amount"].ToString());
            }
            return 0;
        }
        public bool minusFood(string id_food,int amount) //x-amount
        {
            int len = getAmount(id_food);
            if (len < amount) return false;
            else
            {
                amount = len - amount;
                SqlCommand cmd = new SqlCommand("update Food set " +
                "amount=@amount " +
                " where id_food=@id_food",
                connectSql.connection);
                cmd.Parameters.Add("@id_food", SqlDbType.Char).Value = id_food;
                cmd.Parameters.Add("@amount", SqlDbType.Int).Value = amount;
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
        public DataTable getDataFood()
        {
            SqlCommand cmd = new SqlCommand("Select * from Food");
            cmd.Connection = connectSql.connection;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable getDataFoodAvailable()
        {
            SqlCommand cmd = new SqlCommand("Select * from Food where amount!=0");
            cmd.Connection = connectSql.connection;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool insertFood(Food food)
        {
            SqlCommand cmd = new SqlCommand("Insert into Food Values" +
                "(@id_food,@picture,@name_food,@amount,@price)", connectSql.connection);
            cmd.Parameters.Add("@id_food", SqlDbType.Char).Value = food.id_food;
            cmd.Parameters.Add("@picture", SqlDbType.Image).Value = food.cvtByte(food.picture);
            cmd.Parameters.Add("@name_food", SqlDbType.Char).Value = food.name_food;
            cmd.Parameters.Add("@amount", SqlDbType.Int).Value = food.amount;
            cmd.Parameters.Add("@price", SqlDbType.Float).Value = food.price;
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
        public bool updateFood(Food food)
        {
            SqlCommand cmd = new SqlCommand("update Food set " +
                "picture=@picture,name_food=@name_food,amount=@amount,price=@price" +
                " where id_food=@id_food",
                connectSql.connection);
            cmd.Parameters.Add("@id_food", SqlDbType.Char).Value = food.id_food;
            cmd.Parameters.Add("@picture", SqlDbType.Image).Value = food.cvtByte(food.picture);
            cmd.Parameters.Add("@name_food", SqlDbType.Char).Value = food.name_food;
            cmd.Parameters.Add("@amount", SqlDbType.Int).Value = food.amount;
            cmd.Parameters.Add("@price", SqlDbType.Float).Value = food.price;
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
        public bool removeFood(string id_food)
        {
            SqlCommand cmd = new SqlCommand("delete from Food where id_food=@id_food",
                connectSql.connection);
            cmd.Parameters.Add("@id_food", SqlDbType.Char).Value = id_food;
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
