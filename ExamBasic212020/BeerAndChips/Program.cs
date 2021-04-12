using System;

namespace BeerAndChips
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameOFTheFen = Console.ReadLine();
            double expectedBajet = double.Parse(Console.ReadLine());
            int numbersBotteleOfBeer = int.Parse(Console.ReadLine());
            int numbersPaketsOfChips = int.Parse(Console.ReadLine());
            double beerPrice = 1.20 * numbersBotteleOfBeer;
            double chipsPrice = 0.45 * beerPrice;
            double totalChipsPrice = Math.Ceiling(chipsPrice * numbersPaketsOfChips);
            double totalSum = beerPrice + totalChipsPrice;
            if (expectedBajet >= totalSum )
            {
                Console.WriteLine($"{nameOFTheFen} bought a snack and has {expectedBajet - totalSum:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"{nameOFTheFen} needs {totalSum - expectedBajet:f2} more leva!");
            }
            



        }
    }
}
