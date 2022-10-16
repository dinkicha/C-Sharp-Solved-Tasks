using System;

namespace repainting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nylon = double.Parse(Console.ReadLine());
            double paint = double.Parse(Console.ReadLine());
            double thinner =  double.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());

            double sumForNylon = (nylon + 2) * 1.50;
            double priceForPaint = (paint + paint * 0.1) * 14.50;
            double priceThinner = thinner * 5.00;
            double bag = 0.40;
            double totalSum = sumForNylon + priceForPaint + priceThinner + bag;
            double priceForWorkers = (totalSum * 0.30) * hours;
            double result = totalSum + priceForWorkers;

            Console.WriteLine(result);
        }
    }
}
