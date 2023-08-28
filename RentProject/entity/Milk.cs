using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeShop.entity
{
    internal class Milk : CondimentDecorator
    {
        private readonly Beverage beverage;

        public Milk(Beverage beverage)
        {
            this.beverage = beverage;
            this.description = this.beverage.getDescription() + ", Milk";

        }

        public override int cost()
        {
            return 17 + beverage.cost();
        }

        public override string getDescription()
        {
            return this.description;
        }
    }
}
