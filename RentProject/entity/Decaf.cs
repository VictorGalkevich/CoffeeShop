using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.entity
{
    internal class Decaf : Beverage
    {
        private static readonly Decaf INSTANCE = new();

        public Decaf()
        {
            description = "Decaf";
        }

        public static Decaf get()
        {
            return INSTANCE;
        }

        public override int cost()
        {
            return 130;
        }
    }
}
