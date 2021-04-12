using System;

namespace ExamBasic212020
{
    class Program
    {
        static void Main(string[] args)
        {
            int priceForOneVideoCard = int.Parse(Console.ReadLine());
            int priceForOneImport = int.Parse(Console.ReadLine());
            double priceForIncomeEnergyPerADay = double.Parse(Console.ReadLine());
            double profitForOneDay = double.Parse(Console.ReadLine());
            int videoCards = 13;
            int imports = 13;
            int secondHandsParts = 1000;


            int totalVideoCardsPrice = priceForOneVideoCard * videoCards; //1

            int totalImports = priceForOneImport * imports;//2

            double expencesMoney = totalVideoCardsPrice + totalImports + secondHandsParts;//3

            double CardProfitPerDay = profitForOneDay - priceForIncomeEnergyPerADay;//4

            double ProfitPerDay = videoCards * CardProfitPerDay;//5

            double payBack = Math.Ceiling(expencesMoney / ProfitPerDay);//6
            Console.WriteLine($"{expencesMoney}");
            Console.WriteLine($"{payBack}");         
        }
    }
}
