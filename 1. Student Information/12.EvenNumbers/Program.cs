using System;

namespace _12.EvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine($"Please write an even number.");
                }
            }
            
        }
    }
}
