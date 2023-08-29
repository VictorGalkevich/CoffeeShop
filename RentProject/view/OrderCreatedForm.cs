using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.view
{
    public static class OrderCreatedForm
    {
        public static void onSuccess()
        {
            Console.WriteLine("Your order is created successfully, please wait for some time!");
        }

        public static void onFailure()
        {
            Console.WriteLine("Your order wasn't created, please try again or call the administrator!");
        }
    }
}
