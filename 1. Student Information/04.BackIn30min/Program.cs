using System;

namespace _04.BackIn30min
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());
            min += 30;
            if (min>=60)
            {
                hours++;
                min -= 60;
            }
            if (hours==24)
            {
                hours = 0;
            }
            Console.WriteLine($"{hours}:{min:d2}");
        }
    }
}
