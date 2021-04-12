using System;

namespace _07._Hotel_Room
{
    class Program
    {
        static void Main(string[] args)
        {
            string mounth = Console.ReadLine();
            double numOfNight = double.Parse(Console.ReadLine());
            double studio = 0.00;
            double apartment = 0.00;
            if (numOfNight > 7 && numOfNight <= 14)
            {
                if (mounth == "May" || mounth == "October")
                {
                    studio = 47.5 * numOfNight;
                    apartment = 65 * numOfNight;
                }
                else if (mounth == "June" || mounth == "September")
                {
                    studio = 75.20 * numOfNight;
                    apartment = 68.70 * numOfNight;
                }
                else if (mounth == "July" || mounth == "August")
                {
                    studio = 76 * numOfNight;
                    apartment = 77 * numOfNight;
                }
            }
            else if (numOfNight > 14)
            {
                if (mounth == "May" || mounth == "October")
                {
                    studio = 35 * numOfNight;
                    apartment = 58.5 * numOfNight;
                }
                else if (mounth == "June" || mounth == "September")
                {
                    studio = 60.16 * numOfNight;
                    apartment = 61.83 *numOfNight;
                }
                else if (mounth == "July" || mounth == "August")
                {
                    studio = 76 * numOfNight;
                    apartment = 69.3 * numOfNight;
                }
            }
            Console.WriteLine($"Apartment: {apartment:F2} lv.");
            Console.WriteLine($"Studio: {studio:F2} lv.");
        }
    }
}
