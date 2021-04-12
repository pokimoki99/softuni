using System;

namespace _9.Spice_Must_Flow
{
    class Program
    {
        static void Main(string[] args)
        {
            int yeld = int.Parse(Console.ReadLine());
            int dayCount = 0;
            int yeldLeft = 0;
            while (yeld >= 100)
            {
                dayCount++;
                yeldLeft += (yeld - 26);
                yeld -= 10;
            }
            if (yeldLeft > 26)
            {
                yeldLeft -= 26;
            }
            Console.WriteLine(dayCount);
            Console.WriteLine(yeldLeft);
        }
    }
}
