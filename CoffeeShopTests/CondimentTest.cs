using CoffeeShop.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopTests
{
    [TestClass]
    internal class CondimentTest
    {
        [TestMethod]
        public void TestMilk()
        {
            Assert.AreEqual(147, new Milk(Decaf.get()).cost());
        }

        [TestMethod]
        public void TestWhip()
        {
            Assert.AreEqual(155, new Milk(Decaf.get()).cost());
        }

        [TestMethod]
        public void TestMocha()
        {
            Assert.AreEqual(150, new Milk(Decaf.get()).cost());
        }
    }
}
