using CoffeeShop.dao;
using CoffeeShop.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.view
{
    internal static class CreateOrderForm
    {

        private static bool flag = true;
        private static string condimentNumber;
        public static void CreateOrder()
        {
            Console.WriteLine("Please input your name: \n");
            string clientName = Console.ReadLine() ?? "anonymous client";
            Client client = new Client(clientName);
            Console.WriteLine("\n");
            Console.WriteLine("Please choose your coffe type (input number) : \n\n1) Espresso\n2) DarkRoast\n3) Decaf\n4) HouseBlend\n");
            string coffeeNumber = Console.ReadLine() ?? "1";
            Console.WriteLine(string.Empty);
            Beverage beverage;
            switch (coffeeNumber)
            {
                case "1":
                    beverage = Espresso.get();
                    break;
                case "2":
                    beverage = DarkRoast.get();
                    break;
                case "3":
                    beverage = Decaf.get();
                    break;
                case "4":
                    beverage = HouseBlend.get();
                    break;
                default:
                    beverage = Espresso.get();
                    CreateOrderForm.flag = false;
                    break;
            }
            if (!flag)
            {
                OrderCreatedForm.onFailure();
            }
            else
            {
                Beverage beverageWithAddOns = beverage;
                Console.WriteLine("Please choose your condiments (input number) : \n\n1) Milk\n2) Whip\n3) Mocha\n4) That's all\n");
                while ((condimentNumber = Console.ReadLine()) != "4")
                {
                    Console.WriteLine(string.Empty);
                    switch (condimentNumber)
                    {
                        case "1":
                            beverageWithAddOns = new Milk(beverageWithAddOns);
                            break;
                        case "2":
                            beverageWithAddOns = new Whip(beverageWithAddOns);
                            break;
                        case "3":
                            beverageWithAddOns = new Mocha(beverageWithAddOns);
                            break;
                        default:
                            break;
                    }
                    Console.WriteLine("Anything else? (input number) : \n\n1) Milk\n2) Whip\n3) Mocha\n4) That's all\n");
                }
                Order order = new Order(client, beverageWithAddOns.getDescription(), beverageWithAddOns.cost());
                OrderDaoImpl.get().insert(order);
                Console.WriteLine();
                OrderCreatedForm.onSuccess();
                Console.WriteLine();
                Console.WriteLine("Your coffee description: " + beverageWithAddOns.getDescription());
                Console.WriteLine("Price: " + beverageWithAddOns.cost());
            }
        }
    }
}