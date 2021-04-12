using System;

namespace _04._Fishing_Boat
{
    class Program
    {
        static void Main(string[] args)
        {
            int bujet = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int numOfFishingMens = int.Parse(Console.ReadLine());
            double shipPrice = 0.00;
            switch (season)
            {
                case "Spring":
                    if (numOfFishingMens <= 6)
                    {
                        shipPrice = 3000 * 0.9;
                    }
                    else if (numOfFishingMens <= 11)
                    {
                        shipPrice = 3000 * 0.85;
                    }
                    else if (numOfFishingMens >= 12)
                    {
                        shipPrice = 3000 * 0.75;
                    }
                    if (numOfFishingMens %  2 == 0)
                    {
                        shipPrice *= 0.95;
                    }
                    if (bujet >= shipPrice)
                    {
                        Console.WriteLine(($"Yes! You have {(bujet - shipPrice):f2} leva left."));
                    }
                    else if (bujet <= shipPrice)
                    {
                        Console.WriteLine($"Not enough money! You need {(shipPrice - bujet):F2} leva.");
                    }

                    break;
                case "Summer":
                    if (numOfFishingMens <= 6)
                    {
                        shipPrice = 4200 * 0.9;
                    }
                    else if (numOfFishingMens <= 11)
                    {
                        shipPrice = 4200 * 0.85;
                    }
                    else if (numOfFishingMens >= 12)
                    {
                        shipPrice = 4200 * 0.75;
                    }
                    if (numOfFishingMens % 2 == 0)
                    {
                        shipPrice *= 0.95;
                    }
                    if (bujet >= shipPrice)
                    {
                        Console.WriteLine(($"Yes! You have {(bujet - shipPrice):f2} leva left."));
                    }
                    else if (bujet <= shipPrice)
                    {
                        Console.WriteLine($"Not enough money! You need {(shipPrice - bujet):F2} leva.");
                    }

                    break;
                case "Autumn":
                    if (numOfFishingMens <= 6)
                    {
                        shipPrice = 4200 * 0.9;
                    }
                    else if (numOfFishingMens <= 11)
                    {
                        shipPrice = 4200 * 0.85;
                    }
                    else if (numOfFishingMens >= 12)
                    {
                        shipPrice = 4200 * 0.75;
                    }
                    if (bujet >= shipPrice)
                    {
                        Console.WriteLine(($"Yes! You have {(bujet - shipPrice):f2} leva left."));
                    }
                    else if (bujet <= shipPrice)
                    {
                        Console.WriteLine($"Not enough money! You need {(shipPrice - bujet):F2} leva.");
                    }

                    break;
                case "Winter":
                    if (numOfFishingMens <= 6)
                    {
                        shipPrice = 2600 * 0.9;
                    }
                    else if (numOfFishingMens <= 11)
                    {
                        shipPrice = 2600 * 0.85;
                    }
                    else if (numOfFishingMens >= 12)
                    {
                        shipPrice = 2600 * 0.75;
                    }
                    if (numOfFishingMens % 2 == 0)
                    {
                        shipPrice *= 0.95;
                    }
                    if (bujet >= shipPrice)
                    {
                        Console.WriteLine(($"Yes! You have {(bujet - shipPrice):f2} leva left."));
                    }
                    else if (bujet <= shipPrice)
                    {
                        Console.WriteLine($"Not enough money! You need {(shipPrice - bujet):F2} leva.");
                    }
                    break;
            }
        }
    }
}
