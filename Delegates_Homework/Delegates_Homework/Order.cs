using System;
namespace Delegates_Homework
{
    public class Order
    {
        Products[] Products;
        public double TotalPrice;
        DateTime date;

        public Order(Products[] product,double totalPrice)
        {
            TotalPrice = totalPrice;
            Products = product;
        }
    }
}
