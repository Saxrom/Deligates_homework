using System;
namespace Delegates_Homework
{
    public class Products
    {
        public string Name;
        public int Price;
        public static byte Count;

        static Products()
        {
            Count = 0;
        }

        public Products(string name,int price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return $"Name:{Name} , Price:{Price}";
        }
    }
}
