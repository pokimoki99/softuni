using System;

namespace _6._Calculate_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RetungaleArea(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));

        }

        private static int RetungaleArea(int a, int b)
        {
            return a * b;
        }
    }
}
