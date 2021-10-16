using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management_Hotel.Control
{
    public class ConnectSql
    {
        public SqlConnection connection { get; }
        public ConnectSql()
        {
            this.connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;" +
                "Initial Catalog=projectDBMS;Integrated Security=True");
        }
        public void open()
        {
            this.connection.Open();
        }
        public void close()
        {
            this.connection.Close();
        }
    }
}
 