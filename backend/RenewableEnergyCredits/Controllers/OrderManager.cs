using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// Custom library class to handle OrderMatching (NetCore 3.1)
using OrderMatcher;

namespace RenewableEnergyCredits
{
    class OrderManager : IOrderManager
    {
        public void print(string message)
        {
            Console.WriteLine(message);
        }

        public void getBuyOrders()
        {
            Order testOrder = new Order() { Price = 20, OpenQuantity = 2, IsBuy = true };
            Console.WriteLine("Order Price: {}, Open Quantity: {}, Order Filled: {}",
                testOrder.Price, testOrder.OpenQuantity, testOrder.IsFilled);
        }
    }
}
