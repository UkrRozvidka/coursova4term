using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace coursova
{
    internal class Database
    {
        SqlConnection connection = new SqlConnection(@"Data Source=MACHINE\SQLEXPRESS;Initial Catalog=SkiBase;Integrated Security=True");
        public void openConnection()
        {
            if(connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }

        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }

        public SqlConnection GetConnection()
        {
            return connection;
        }

    }

}
