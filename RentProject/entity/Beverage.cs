using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeShop.entity
{
    internal abstract class Beverage
    {
        protected string description = "description";

        public string getDescription()
        {
            return description;
        }

        protected Beverage() { }

        public abstract int cost();
    }
}
