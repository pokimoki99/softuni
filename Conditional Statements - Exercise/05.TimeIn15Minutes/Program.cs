using System;

namespace _05.TimeIn15Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());
            min += 15;
            string output = "";
            if (min >= 60)
            {
                hours += 1;
                min = min - 60;
            }
             if (hours >= 24)
            {
                hours = 0;
            }
            if (min < 10)
            {
                output = $"{hours}:0{min}";
            }
            else
            {
                output = $"{hours}:{min}";
            }
            Console.WriteLine(output);
        }
    }
}
