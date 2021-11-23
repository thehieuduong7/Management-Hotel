using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Drawing;

namespace Management_Hotel.Control
{
    public class ConnectionController
    {
        public static SqlConnection connection { get; set; }    
        public static void init()
        {
            if (ConnectionController.connection == null)
                ConnectionController.connection =
                 new SqlConnection(@"Data Source=DESKTOP-AV5GUUN\SQLEXPRESS;Initial Catalog=projectDBMS;Integrated Security=True");

            new SqlConnection( @"Data Source=DESKTOP-AV5GUUN\SQLEXPRESS;Initial Catalog=projectDBMS;User ID=thehieu");
            connection.Open();

        }
        public static bool login(String username, string password)
        {
            String connect_str = String.Format(@"Data Source=DESKTOP-AV5GUUN\SQLEXPRESS;Initial Catalog=projectDBMS;" +
                "User ID={0};Password={1};",username,password);
            try
            {
                ConnectionController.connection =
                new SqlConnection(connect_str);
                if (ConnectionController.connection == null)
                    return false;
                ConnectionController.connection.Open();
                return true;
            }
            catch (SqlException)
            {
                ConnectionController.connection = null;
                return false;
            }
        }
        public static void logout()
        {
            if (ConnectionController.connection == null) return;
            ConnectionController.connection.Close();
            ConnectionController.connection.Dispose();
            ConnectionController.connection = null;
        }
        public static void open()
        {
            connection.Open();
        }
        public static void close()
        {
            connection.Close();
        }
        public static bool execute(SqlCommand cmd)
        {
            cmd.Connection = connection;
           //connection.Open();
            bool result = false;
            try
            {
                // result = (cmd.ExecuteNonQuery() == 1);
                cmd.ExecuteNonQuery();
                result = true;
            }
            catch (SqlException)
            {
                return false;
            }
            finally
            {
              // connection.Close();
            }
            return result;
        }
        public static DataTable getData(SqlCommand cmd)
        {
            //connection.Open();
            cmd.Connection = connection;
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
            catch (SqlException)
            {
                return null;
            }
            finally
            {
                //connection.Close();

            }
        }
        public static SqlTransaction beginTransaction()
        {
            return connection.BeginTransaction();
        }
    }
}
