using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeShop.entity
{
    internal class Espresso : Beverage
    {
        private static readonly Espresso INSTANCE = new();

        public Espresso()
        {
            description = "Espresso";
        }

        public static Espresso get()
        {
            return INSTANCE;
        }

        public override int cost()
        {
            return 80;
        }
    }
}
