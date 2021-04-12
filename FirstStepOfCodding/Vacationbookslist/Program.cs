using System;

namespace Vacationbookslist
{
    class Program
    {
        static void Main(string[] args)
        {
            int lastPagesNow = int.Parse(Console.ReadLine());
            double pagesForHour = double.Parse(Console.ReadLine());
            int numbersOfDays = int.Parse(Console.ReadLine());
            double totalTimeReading = lastPagesNow / pagesForHour;
            double readingHours = totalTimeReading / numbersOfDays;
            Console.WriteLine(readingHours);

        }
    }
}
