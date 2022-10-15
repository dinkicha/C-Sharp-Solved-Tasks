using System;

namespace basketballEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double taxForTrainingYearly = double.Parse(Console.ReadLine());

            double priceForShoes = taxForTrainingYearly * 0.60;
            double priceForClothes = priceForShoes * 0.80;
            double priceForBall = priceForClothes * 0.25;
            double priceForАccessories = priceForBall * 0.20;

            double totalSum = taxForTrainingYearly + priceForBall + priceForClothes + priceForShoes + priceForАccessories;

            Console.WriteLine($"{totalSum:f2}");

        }
    }
}
