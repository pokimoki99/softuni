using System;

namespace Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double MoneyAvailable = double.Parse(Console.ReadLine());
            int StudentsCount = int.Parse(Console.ReadLine());
            double PriceForASabre = double.Parse(Console.ReadLine());
            double PriceForARobe = double.Parse(Console.ReadLine());
            double PriceForABelt = double.Parse(Console.ReadLine());

            double totalMoneyNeeded = (PriceForARobe * StudentsCount) + (PriceForASabre * (Math.Ceiling(StudentsCount * 1.10)) + (PriceForABelt * StudentsCount) - (PriceForABelt * (StudentsCount / 6)));
             double difference = totalMoneyNeeded - MoneyAvailable;
         if (totalMoneyNeeded > MoneyAvailable) 
            {
                Console.WriteLine($"Ivan Cho will need {difference:f2}lv more.");
            }
            else
            {
                Console.WriteLine($"The money is enough - it would cost {totalMoneyNeeded:f2}lv.");
             }
 
        }
    }
}
