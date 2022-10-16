using System;

namespace areaOfFigures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();

            if (figure == "square")
            {
                double figureOne = double.Parse(Console.ReadLine());
                double area = figureOne * figureOne;
                Console.WriteLine($"{area:F3}");
            }
            else if (figure == "rectangle")
            {
                double figureTwo = double.Parse(Console.ReadLine());
                double figure2 = double.Parse(Console.ReadLine());
                double area = figure2 * figureTwo;
                Console.WriteLine($"{area:F3}");
            }
            else if (figure == "circle")
            {
                double figureThree = double.Parse(Console.ReadLine());
                double area = Math.PI * figureThree * figureThree;
                Console.WriteLine($"{area:F3}");
            }
            else if (figure == "triangle")
            {
                double figureFour = double.Parse(Console.ReadLine());
                double figure4 = double.Parse(Console.ReadLine());
                double area = figure4 * figureFour / 2;
                Console.WriteLine($"{area:F3}");
            }
        }
    }
}
