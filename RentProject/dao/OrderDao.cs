using CoffeeShop.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.dao
{
    public interface OrderDao : Dao<Order>
    {
        public new int delete(Order t);

        public new Order getById(int id);

        public new List<Order> getAll();

        public new int insert(Order t);

        public new int update(Order t);
    }
}
