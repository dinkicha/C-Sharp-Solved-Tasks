using System;

namespace zooShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dogsFood = int.Parse(Console.ReadLine());
            int catsFood = int.Parse(Console.ReadLine());
            Console.WriteLine((dogsFood * 2.50) + (catsFood * 4) +  " lv.");
        }
    }
}
