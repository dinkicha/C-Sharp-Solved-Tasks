using System;

namespace educationMaterial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int packetPens = int.Parse(Console.ReadLine());
            int packetMarkers = int.Parse(Console.ReadLine());
            double litres = double.Parse(Console.ReadLine());
            double discount = double.Parse(Console.ReadLine());

            double pricePens = packetPens * 5.80;
            double priceMarkers = packetMarkers * 7.20;
            double priceLitres = litres * 1.20;
            double totalSum = pricePens + priceMarkers + priceLitres;
            double sumWithDiscount = totalSum * 0.75;
            Console.WriteLine(sumWithDiscount);
        }
    }
}
