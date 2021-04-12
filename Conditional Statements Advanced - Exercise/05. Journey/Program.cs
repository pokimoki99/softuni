using System;

namespace _05._Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double bujet = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double expences = 0.0;
            string acomodation = "";
            string destination = "";
            if (bujet <= 100)
            {
                destination ="Bulgaria";
                if (season == "summer")
                {
                    acomodation = "Camp";
                    expences = bujet * 0.3;
                }
                else if (season == "winter")
                {
                    acomodation = "Hotel";
                    expences = bujet * 0.7;
                }
            }
            else if (bujet <= 1000)
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    acomodation = "Camp";
                    expences = bujet * 0.4;
                }
                else if (season == "winter")
                {
                    acomodation = "Hotel";
                    expences = bujet * 0.8;
                }
            }
            else if (bujet > 1000)
            {
                destination = "Europe";
                acomodation = "Hotel";
                expences = bujet * 0.9;
            }
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{acomodation} - {expences:F2}");
        }
       
    }
}
