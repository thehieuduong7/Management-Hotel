﻿using System;
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
           connection.Open();
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
               connection.Close();
            }
            return result;
        }
        public static DataTable getData(SqlCommand cmd)
        {
            connection.Open();
            cmd.Connection = connection;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            connection.Close();
            return table;
        }
        public static SqlTransaction beginTransaction()
        {
            connection.Open();
            return connection.BeginTransaction();
        }
    }
}
