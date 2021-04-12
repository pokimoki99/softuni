using System;

namespace _07.WorldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double recordInSec = double.Parse(Console.ReadLine());
            double distanseInMeters = double.Parse(Console.ReadLine());
            double timeInSeconds = double.Parse(Console.ReadLine());
            double waterSlow = distanseInMeters * timeInSeconds;
            double overTime = Math.Floor(distanseInMeters / 15) * 12.5;
            double totalTime = waterSlow + overTime;
            double notArecord = totalTime - recordInSec;
            if (totalTime < recordInSec)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {totalTime:f2} seconds.");
            }
            else if (totalTime >= recordInSec)
            {
                Console.WriteLine($"No, he failed! He was {notArecord:f2} seconds slower.");
            }
        }
    }
}
