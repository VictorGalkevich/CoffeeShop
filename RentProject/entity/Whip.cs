using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.entity
{
    public class Whip : CondimentDecorator
    {
        private readonly Beverage beverage;

        public Whip(Beverage beverage)
        {
            this.beverage = beverage;
            this.description = this.beverage.getDescription() + ", Whip";

        }

        public override int cost()
        {
            return 25 + beverage.cost();
        }

        public override string getDescription()
        {
            return this.description;
        }
    }
}
