using System;

namespace ExamMid
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine()); //days for plunder  
            int plunder_per_day = int.Parse(Console.ReadLine()); //plunder per day
            double expected_plunder = double.Parse(Console.ReadLine()); //expected plunder


            //every third (3) day they gain an additional 50% of their daily (plunder * 1.5)

            // every fifth (5) day they lose 30% of their total plunder (total *0.7)

            double total_plunder = 0.0;

            for (int i = 1; i <= days; i++)
            {
                total_plunder += plunder_per_day;
                if (i % 3 == 0)
                {
                    total_plunder += plunder_per_day * 0.5;
                }
                if (i % 5 == 0)
                {
                    total_plunder -= total_plunder * 0.3;
                }

            }


            if (expected_plunder <= total_plunder) //if total plunder is bigger than expected
            {
                Console.WriteLine($"Ahoy! {total_plunder:0.00} plunder gained.");
            }
            else
            {
                double percentage = (total_plunder / expected_plunder) * 100;
                Console.WriteLine($"Collected only {percentage:0.00}% of the plunder.");
            }
        }
    }
}
