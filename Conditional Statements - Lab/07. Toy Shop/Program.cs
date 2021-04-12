using System;

namespace _07._Toy_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            double tripMoney = double.Parse(Console.ReadLine());
            int numOfPuzzels = int.Parse(Console.ReadLine());
            int numOfDools = int.Parse(Console.ReadLine());
            int numOfBears = int.Parse(Console.ReadLine());
            int numOfMinions = int.Parse(Console.ReadLine());
            int numOfTracks = int.Parse(Console.ReadLine());
            double puzzelsPrice = 2.60;
            double doolsPrice = 3;
            double bearPrice = 4.10;
            double minionPrice = 8.20;
            double trackPrice = 2;
            double numbersOfToys = numOfPuzzels + numOfDools + numOfBears + numOfMinions + numOfTracks;
            double toysPrice = numOfPuzzels * 2.60 + numOfDools * 3 + numOfBears * 4.10 + numOfMinions * 8.20 + numOfTracks * 2;
            if (numbersOfToys >= 50)
            {
                toysPrice = toysPrice - toysPrice * 0.25;
            }
            toysPrice -= toysPrice * 0.1;
            if (toysPrice >= tripMoney)
            {
                Console.WriteLine($"Yes! {(toysPrice - tripMoney):f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {(tripMoney - toysPrice):f2} lv needed.");
            }

        }
    }
}
