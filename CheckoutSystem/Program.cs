using System;

namespace CheckoutSystem
{


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is to call the class create order and calculate the order amount");
            CreateOrder order = new CreateOrder();
            order.Total(1, 1, 1);
        }
    }
}
