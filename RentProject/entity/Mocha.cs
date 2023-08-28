using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.entity
{
    internal class Mocha : CondimentDecorator
    {
        private readonly Beverage beverage;

        public Mocha(Beverage beverage)
        {
            this.beverage = beverage;
            this.description = this.beverage.getDescription() + ", Mocha";
        }

        public override int cost()
        {
            return 20 + beverage.cost();
        }

        public override string getDescription()
        {
            return this.description;
        }
    }
}
