using System;

namespace _04.MetricConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            string output = Console.ReadLine();
            if (input == "cm")
            {
                number /= 100;
            }
            else if (input == "mm")
            {
                number /= 1000;
            }
            else if (input == "m")
            {

            }
            if (output == "cm")
            {
                number *= 100;
            }
            else if (output == "mm")
            {
                number *= 1000;
            }
            Console.WriteLine($"{number:f3}");
        }
    }
}
