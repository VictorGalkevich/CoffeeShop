using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeShop.entity
{
    internal abstract class CondimentDecorator : Beverage
    {
        public new abstract string getDescription();
    }
}
