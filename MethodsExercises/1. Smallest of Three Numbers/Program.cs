using System;

namespace _1._Smallest_of_Three_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int min = MinNum(num1, num2, num3);
            Console.WriteLine(min);

        }
        static int MinNum(int num1, int num2, int num3)
        {
            return Math.Min(Math.Min(num1, num2), num3);// namirame nai malkoto ot 4islata
        }
    }
}
