using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.entity
{
    public class Order
    {
        private static int id;
        private readonly int idorder;

        private readonly Client client;

        private readonly string orderDescription;

        private readonly int orderCost;


        public Order(Client client, string orderDescription, int orderCost)
        {
            this.client = client;
            this.orderDescription = orderDescription;
            this.orderCost = orderCost;
            this.idorder = ++id;
        }

        public int getId() { return idorder; }

        public string getDescription() { return orderDescription;}
        public int getCost() { return orderCost;}
    }
}
