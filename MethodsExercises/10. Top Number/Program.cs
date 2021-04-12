using System;

namespace _10._Top_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            PrintTopNumber(number);
        }

        private static void PrintTopNumber(int number)
        {
            for (int i = 0; i <= number; i++)
            {
                bool isOdd = false;
                string currentNumber = i.ToString();
                int sum = 0;
                foreach (var curr in currentNumber)
                {
                    int parseNumber = (int)curr;
                    if (parseNumber % 2 == 1)
                    {
                        isOdd = true;
                    }
                    sum += parseNumber;
                }
                if (sum % 8 == 0 && isOdd)
                {
                    Console.WriteLine(i);
                }
            }


        }
    }
}
