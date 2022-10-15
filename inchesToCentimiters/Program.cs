using System;

namespace inchesToCentimiters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double inches = double.Parse(Console.ReadLine()); //When reading a double number from the console we write double and double.Parse
            Console.WriteLine(Math.Round(inches * 2.54 , 2));
        }
    }
}
