using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeShop.entity;
using CoffeeShop.dao;

namespace CoffeeShopTests
{
    [TestClass]
    internal class DaoTest
    {
        [TestMethod]
        public void TestDaoPositive()
        {
            Client client = new Client("Victor");
            Beverage beverage = new Whip(new Mocha(DarkRoast.get()));
            Order order = new Order(client, beverage.getDescription(), beverage.cost());
            Assert.AreEqual(1, OrderDaoImpl.get().insert(order));
        }

        [TestMethod]
        public void TestDaoNegative()
        {
            Assert.AreEqual(1, OrderDaoImpl.get().insert(null));
        }
    }
}
