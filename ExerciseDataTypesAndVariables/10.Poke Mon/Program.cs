using System;
using System.Net.Security;

namespace _10.Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            //int n = int.Parse(Console.ReadLine()); //poke power
            //int m = int.Parse(Console.ReadLine());// distance
            //byte y = byte.Parse(Console.ReadLine());//exhaustionFactor
            //int targetCount = 0;
            //int originalValue = n;
            //while (n >= m)
            //{
            //    if (n == originalValue / 2)
            //    {
            //        if (y > 0)                             //!!!!!!
            //        {
            //            n /= y;
            //            continue;
            //        }
            //    }
            //    n -= m;
            //    targetCount++;
            //}
            //Console.WriteLine(n);
            //Console.WriteLine(targetCount);
            int power = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exaustedFactor = int.Parse(Console.ReadLine());
            double halfpower = 1.0 * power / 2;
            int pokes = 0;
            while (power>=distance)
            {
                power -= distance;
                pokes++;
                if (power == halfpower)
                {
                    if (exaustedFactor != 0)
                    {
                    power /= exaustedFactor;
                    }
                }
            }
       Console.WriteLine(power);
     Console.WriteLine(pokes);
        }
    }
}
