using System;

namespace _02._Summer_Outfit
{
    class Program
    {
        static void Main(string[] args)
        {
            //"Sweatshirt" "Sneakers" "Shirt" "Moccasins" "T-Shirt" "Sandals"
            int degree = int.Parse(Console.ReadLine());
            string dayTime = Console.ReadLine();
            string shoes = "";
            string outfit = "";
            switch (dayTime)
            {
                case "Morning":
                    if (10 <= degree && degree <= 18)
                    {
                    outfit = "Sweatshirt";
                    shoes = "Sneakers";
                    }
                    else if (18 < degree && degree <= 24)
                    {
                        outfit = "Shirt";
                        shoes = "Moccasins";
                    }
                    else if (degree>=25)
                    {
                        outfit = "T-Shirt";
                        shoes = "Sandals";
                    }
                    break;
                case "Afternoon":
                    if (10 <= degree && degree <= 18)
                    {
                        outfit = "Shirt";
                        shoes = "Moccasins";
                    }
                    else if (18 < degree && degree <= 24)
                    {
                        outfit = "T-Shirt";
                        shoes = "Sandals";
                    }
                    else if (degree >= 25)
                    {
                        outfit = "Swim Suit";
                        shoes = "Barefoot";
                    }
                    break;
                case "Evening":
                    if (10 <= degree && degree <= 18)
                    {
                        outfit = "Shirt";
                        shoes = "Moccasins";
                    }
                    else if (18 < degree && degree <= 24)
                    {
                        outfit = "Shirt";
                        shoes = "Moccasins";
                    }
                    else if (degree >= 25)
                    {
                        outfit = "Shirt";
                        shoes = "Moccasins";
                    }
                    break;
            }
            Console.WriteLine($"It's {degree} degrees, get your {outfit} and {shoes}.");
        }
    }
}
