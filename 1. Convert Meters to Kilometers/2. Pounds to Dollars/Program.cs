using System;

namespace _2._Pounds_to_Dollars
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal pounds = decimal.Parse(Console.ReadLine());
            decimal dolars = pounds * 1.31M;
            Console.WriteLine($"dolars:f3");
        }
    }
}
