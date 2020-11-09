using System;

namespace CheckoutSystem
{


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            CreateOrder order = new CreateOrder();
            order.Total(1, 1, 1);
        }
    }
}
