using System;
using System.Collections.Generic;

namespace Delegates_Homework
{
    public class Order
    {
        public List<Products> Orders;

        public Order()
        {
            Orders = new List<Products>();
        }


        public void Sale(Products product,byte count)
        {
            for (int i = 0; i <count; i++)
            {
                Console.WriteLine(product);
            }
        }

        public List<Products> Get()
        {
            DateTimeOffset now = DateTimeOffset.Now;
            Console.WriteLine(now);

            return Orders;
        }

        public int TotalPrice()
        {
            int total = 0;
            foreach (Products product in Orders)
            {
                total += product.Price;
            }

            return total;
        }
    }
}
