using System;

namespace DepositCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double depositSum = double.Parse(Console.ReadLine());
            int depositInMounth = int.Parse(Console.ReadLine());
            double yearPresent = double.Parse(Console.ReadLine());
            double inForAMounth = (depositSum * yearPresent * 0.01 / 12);
            double total = depositSum + depositInMounth * inForAMounth;
        
            Console.WriteLine(total);
        }
    }
}
