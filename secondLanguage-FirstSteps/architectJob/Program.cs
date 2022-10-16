using System;

namespace architectJob
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int projects = int.Parse(Console.ReadLine());
            Console.WriteLine($"The architect {name} will need {projects * 3} hours to complete {projects} project/s.");
        }
    }
}
