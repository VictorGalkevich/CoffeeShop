using CoffeeShop.entity;

namespace CoffeeShopTests
{
    [TestClass]
    public class CoffeeTest
    {
        [TestMethod]
        public void TestHouseBlend()
        {
            Assert.AreEqual(120, HouseBlend.get().cost());
        }

        [TestMethod]
        public void TestEspresso()
        {
            Assert.AreEqual(80, Espresso.get().cost());
        }

        [TestMethod]
        public void TestDecaf()
        {
            Assert.AreEqual(130, Decaf.get().cost());
        }

        [TestMethod]
        public void TestDarkRoast()
        {
            Assert.AreEqual(100, DarkRoast.get().cost());
        }
    }
}