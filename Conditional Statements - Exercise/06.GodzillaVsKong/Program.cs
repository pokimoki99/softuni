using System;

namespace _06.GodzillaVsKong
{
    class Program
    {
        static void Main(string[] args)
        {
            double bujet = double.Parse(Console.ReadLine());
            int numberOfStatistic = int.Parse(Console.ReadLine());
            double priceOfDress = double.Parse(Console.ReadLine());
            double decor = bujet * 0.10;
            double dressSum = numberOfStatistic * priceOfDress;
            if (numberOfStatistic > 150)
            {
                dressSum = dressSum - dressSum * 0.10;
            }
            double totalSum = dressSum + decor;
            if (totalSum > bujet)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {totalSum - bujet:f2} leva more.");
            }
            else if (totalSum <= bujet)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {bujet - totalSum:f2} leva left.");
            }
        }
    }
}
