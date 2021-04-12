using System;

namespace _05._Small_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string city = Console.ReadLine();
            double quanty = double.Parse(Console.ReadLine());
            double price = 0.0;
            switch (city)
            {
                case "Sofia":
                    if (product == "coffee")
                    {
                        price = 0.50 * quanty;
                    }
                    else if (product == "water")
                    {
                        price = 0.80 * quanty;
                    }
                    else if (product == "beer")
                    {
                        price = 1.20 * quanty;
                    }
                    else if (product == "sweets")
                    {
                        price = 1.45 * quanty;
                    }
                    else if (product == "peanuts")
                    {
                        price = 1.60 * quanty;
                    }
                    break;
                case "Plovdiv":
                    if (product == "coffee")
                    {
                        price = 0.40 * quanty;
                    }
                    else if (product == "water")
                    {
                        price = 0.70 * quanty;
                    }
                    else if (product == "beer")
                    {
                        price = 1.15 * quanty;
                    }
                    else if (product == "sweets")
                    {
                        price = 1.30 * quanty;
                    }
                    else if (product == "peanuts")
                    {
                        price = 1.50 * quanty;
                    }
                    break;
                case "Varna":
                    if (product == "coffee")
                    {
                        price = 0.45 * quanty;
                    }
                    else if (product == "water")
                    {
                        price = 0.70 * quanty;
                    }
                    else if (product == "beer")
                    {
                        price = 1.10 * quanty;
                    }
                    else if (product == "sweets")
                    {
                        price = 1.35 * quanty;
                    }
                    else if (product == "peanuts")
                    {
                        price = 1.55 * quanty;
                    }
                    break;
            }
            Console.WriteLine(Math.Round(price,4));

        }
    }
}
