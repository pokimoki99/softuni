using System;

namespace PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbursOfDogs = int.Parse(Console.ReadLine());
            int otherDogs = int.Parse(Console.ReadLine());
            double foodPrice = 2.50;
            double otherFoodPrice = 4;
            double totalSum = (numbursOfDogs * foodPrice) + (otherDogs * otherFoodPrice);
            Console.WriteLine($"{totalSum} lv.");
        }
    }
}
