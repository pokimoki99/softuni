using System;

namespace _06._Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figureName = Console.ReadLine();
            double result = 0.0;
            if (figureName == "square")
            {
                double squereside = double.Parse(Console.ReadLine());
                result = squereside * squereside;
            }
            else if (figureName == "rectangle")
            {
                double firstSide = double.Parse(Console.ReadLine());
                double secondSide = double.Parse(Console.ReadLine());
                result = firstSide * secondSide;
            }
            else if (figureName == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                result = radius * radius * Math.PI;
            }
            else if (figureName == "triangle")
            {
                double lenght = double.Parse(Console.ReadLine());
                double high = double.Parse(Console.ReadLine());
                result = lenght * high / 2;
            }
            Console.WriteLine($"{result:f3}");
        }
    }
}
