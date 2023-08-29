using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.entity
{
    public class HouseBlend : Beverage
    {
        private static readonly HouseBlend INSTANCE = new();

        public HouseBlend()
        {
            description = "House BLend";
        }

        public static HouseBlend get() {
            return INSTANCE; 
        }

        public override int cost()
        {
            return 120;
        }
    }
}
