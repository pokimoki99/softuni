using System;

namespace _7._Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int totalLitters = 0;
            for (int i = 0; i < n; i++)
            {
                int litters = int.Parse(Console.ReadLine());
                if (totalLitters + litters > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    totalLitters += litters;   
                }
            }
            Console.WriteLine(totalLitters);
        }
    }
}
