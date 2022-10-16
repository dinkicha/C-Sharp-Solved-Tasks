using System;

namespace fishTank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double lengthInCm = double.Parse(Console.ReadLine());
            double widthInCm = double.Parse(Console.ReadLine());
            double heightInCm = double.Parse(Console.ReadLine());
            double percentage = double.Parse(Console.ReadLine());

            double freeSpace = lengthInCm * widthInCm * heightInCm;
            double placeInLitres = freeSpace / 1000;
            double takenPlace = percentage / 100;
            double neededLiters = placeInLitres * (1 - takenPlace);

            Console.WriteLine(neededLiters);
        }
    }
}
