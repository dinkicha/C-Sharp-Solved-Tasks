using System;

namespace depositCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sum = double.Parse(Console.ReadLine());
            int time = int.Parse(Console.ReadLine()); 
            double percentage = double.Parse(Console.ReadLine());

            double interest = sum * percentage / 100;
            double interestForOneMonth = interest / 12;
            double totalSum = sum + (time * interestForOneMonth);

            Console.WriteLine($"{totalSum:f2}");
        }
    }
}
