using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.entity
{
    public abstract class CondimentDecorator : Beverage
    {
        public new abstract string getDescription();
    }
}
