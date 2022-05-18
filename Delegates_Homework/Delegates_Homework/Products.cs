using System;
namespace Delegates_Homework
{
    public class Products
    {
        public string Name;
        public double Price;
        public static byte Count;

        static Products()
        {
            Count = 0;
        }

        public Products(string name,double price)
        {
            Name = name;
            Price = price;
        }
    }
}
