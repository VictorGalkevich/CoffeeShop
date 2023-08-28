using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeShop.dao
{
    internal class Database
    {
        private readonly static MySqlConnection connection = new("server=localhost;port=3306;username=root;password=root;database=orders");

        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public static MySqlConnection getConnection()
        {
            return connection;
        }
    }
}
