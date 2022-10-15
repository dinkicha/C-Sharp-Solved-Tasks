using System;

namespace foodDelivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double chicken = double.Parse(Console.ReadLine());
            double fish = double.Parse(Console.ReadLine());
            double vegeterian = double.Parse(Console.ReadLine());

            double priceForChicken = chicken * 10.35;
            double priceForFish = fish * 12.40;
            double priceForVegeterian = vegeterian * 8.15;

            double totalSum = priceForChicken + priceForFish + priceForVegeterian;
            double priceForDessert = totalSum * 0.20;
            double priceForDelivery = 2.50;

            double result = totalSum + priceForDessert + priceForDelivery;

            Console.WriteLine(result);

        }
    }
}
