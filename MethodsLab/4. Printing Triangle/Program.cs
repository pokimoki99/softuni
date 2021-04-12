using System;

namespace _4._Printing_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
           int n = int.Parse(Console.ReadLine());
            PrintTringle(n);
        }
        static void PrintTringle(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                PrintNumbersFrom1(i);//tova 6te vurti ot 1-4
            }
            for (int i = n - 1; i > 0; i--)
            {
                PrintNumbersFrom1(i);//vurti naobratno 4-1
            }
        }
        static void PrintNumbersFrom1(int toSomwhere)
        {
            for (int i = 1; i <= toSomwhere; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
