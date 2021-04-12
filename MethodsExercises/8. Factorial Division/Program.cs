using System;

namespace _8._Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            decimal result = CalcFacturial(num1) / CalcFacturial(num2);
            Console.WriteLine($"{result:f2}");
        }

        private static decimal CalcFacturial(int num)
            //5! = 1*2*3*4*5
        {
            decimal factorial = 1;
            for (int i = 1; i < num; i++)
            {
                factorial *= 1;
            }
            return factorial;
        }
    }
}
