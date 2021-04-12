using System;

namespace Conditional_Statements___Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            double bonus = 0.0;
            if (numbers <= 100)
            {
                bonus += 5;
            }
            else if (numbers < 1000)
            {
                bonus = numbers * 0.2;
            }
            else 
            {
                bonus = numbers * 0.1;
            }
            if (numbers % 2==0)
            {
                bonus += 1;
            }
            else if (numbers % 10 == 5)
            {
                bonus += 2;
            }
            Console.WriteLine(bonus);
            Console.WriteLine(numbers + bonus);
        }
    }
}
