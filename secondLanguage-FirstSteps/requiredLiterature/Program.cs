using System;

namespace requiredLiterature
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pages = int.Parse(Console.ReadLine());
            int pagesForOneHour = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            int totalTime = pages / pagesForOneHour;
            int neededHours = totalTime / days;
            Console.WriteLine(neededHours);
        }
    }
}
