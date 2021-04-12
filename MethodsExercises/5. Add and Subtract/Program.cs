using System;

namespace _5._Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            int sum = Sum(first, second, third);
            Console.WriteLine(sum);
        }

        private static int Sum(int first, int second, int third)
        {
            int sumFirstSecond = first + second;
            return Subtrct(sumFirstSecond, third);
        }

        private static int Subtrct(int sumFirstSecond, int third)
        {
            return sumFirstSecond - third;
        }
    }
}
