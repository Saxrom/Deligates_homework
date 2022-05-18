using System;

namespace Delegates_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order();

            Products Water = new Products("Water", 100);
            Products Milk = new Products("Milk", 50);

            order.Sale(Water, 3);
            order.Sale(Milk, 2);

            Predicate<Order> NoDiscout = totalPrice =>
            {
                return order.TotalPrice() < 100;
            };

            Predicate<Order> Discout20 = totalPrice =>
            {
                return order.TotalPrice() > 20;
            };

            if (NoDiscout(order))
            {
                Console.WriteLine("The purchase price is less 100man.No discount");
            }

            else if (Discout20(order))
            {
                Console.WriteLine("The purchase price is more 100man.Discont 20%");
                Console.WriteLine($"Discounted price:{order.TotalPrice()*0.8}");
            }

            else
            {
                Console.WriteLine("Discount 10%");
                Console.WriteLine($"Discounted price:{order.TotalPrice()*0.9}");
            }
        }
    }
}
