using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.entity
{
    public class DarkRoast : Beverage
    {
        private static readonly DarkRoast INSTANCE = new();
        private DarkRoast()
        {
            description = "DarkRoast";
        }

        public static DarkRoast get()
        {
            return INSTANCE;
        }

        public override int cost()
        {
            return 100;
        }
    }
}
