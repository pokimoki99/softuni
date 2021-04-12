using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _8.LettersChangeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            double result = 0;
            string alfabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            for (int i = 0; i < input.Length; i++)
            {
                string curr = input[i];
                char firstLetter = curr[0];
                char lastletter = curr[curr.Length - 1];
                double number = double.Parse(curr.Substring(1, curr.Length - 2));
                int firstElement = alfabet.IndexOf(char.ToUpper(firstLetter));
                int secondElement = alfabet.IndexOf(char.ToUpper(lastletter));
                if ((int)firstLetter>=65 && (int)firstLetter <= 90)
                {
                    number = number / (firstElement + 1);

                }
                else
                {
                    number = number * (firstElement + 1);
                }
                if ((int)lastletter >= 65 && (int)lastletter <= 90)
                {
                    number = number - (secondElement + 1);
                }
                else
                {
                    number = number + (secondElement + 1);
                }

                    result += number;
            }
            Console.WriteLine($"{result:f2}");
        }
    }
}
