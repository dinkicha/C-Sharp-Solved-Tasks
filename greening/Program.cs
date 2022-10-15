using System;

namespace greening
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double metres = double.Parse(Console.ReadLine());

            double price = metres * 7.61;
            double priceWithDiscount = price * 0.82;

            Console.WriteLine($"The final price is: {priceWithDiscount:f2} lv.");
            Console.WriteLine($"The discount is: {price - priceWithDiscount:f2} lv.");
        }
    }
}
