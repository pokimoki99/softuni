using System;

namespace BirthdayParty
{
    class Program
    {
        static void Main(string[] args)
        {
            double rentOfTheHall = double.Parse(Console.ReadLine());
            double cakePrice = rentOfTheHall * 0.2;
            double drinkPrice = cakePrice - (cakePrice * 0.45);
            double animatorPrice = rentOfTheHall / 3;
            double total = rentOfTheHall + cakePrice + drinkPrice + animatorPrice;
            Console.WriteLine(total);
        }
    }
}
