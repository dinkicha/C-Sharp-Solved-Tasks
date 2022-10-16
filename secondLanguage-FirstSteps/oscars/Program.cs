using System;

namespace oscars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double rent = double.Parse(Console.ReadLine());

            double priceForStatues = rent * 0.70;
            double priceForFood = priceForStatues * 0.85;
            double priceForPlayback = priceForFood / 2;

            double totalSum = rent + priceForStatues + priceForFood + priceForPlayback;

            Console.WriteLine($"{totalSum:f2}");
        }
    }
}
