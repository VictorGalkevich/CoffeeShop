using CoffeeShop.entity;
using CoffeeShop.exception;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.dao
{
    internal class OrderDaoImpl : OrderDao
    {
        private static readonly OrderDaoImpl INSTANCE = new OrderDaoImpl();

        private static readonly String SQL_INSERT_ORDER = "INSERT INTO orders(idorder, description, cost) VALUES(@val1, @val2, @val3)";

        public int delete(Order t)
        {
            throw new NotImplementedException();
        }

        public Order getById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Order> getAll()
        {
            throw new NotImplementedException();
        }

        public int insert(Order t)
        {
            if (t == null)
            {
                return -1;
            }
            try
            {
                MySqlConnection connection = Database.getConnection();
                connection.Open();
                MySqlCommand command = new MySqlCommand(SQL_INSERT_ORDER);
                command.Prepare();
                command.Parameters.AddWithValue("@val1", t.getId());
                command.Parameters.AddWithValue("@val2", t.getDescription());
                command.Parameters.AddWithValue("@val3", t.getCost());
                return command.ExecuteNonQuery();
            }catch (Exception ex)
            {
                throw new DaoException("Exception in insert block\n" + ex.Message);
            }
        }

        public int update(Order t)
        {
            throw new NotImplementedException();
        }

        public static OrderDaoImpl get()
        {
            return INSTANCE;
        }
    }
}
