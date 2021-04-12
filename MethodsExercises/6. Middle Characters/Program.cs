﻿using System;

namespace _6._Middle_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string output = String.Empty;
            if (input.Length % 2 == 0)
            {
                output = GetMiddleCharFromEvenStringLenght(input);
            }
            else
            {
                output = GetMiddleCharFromOddStringLenght(input);    
            }
            Console.WriteLine(output);
        }

        private static string GetMiddleCharFromOddStringLenght(string input)
        {
            int index = input.Length / 2;
            string chars = input.Substring(index,1);//razdelq bukvite
            return chars;
        }

        private static string GetMiddleCharFromEvenStringLenght(string input)
        {
            int index = input.Length / 2;
            string chars = input.Substring(index - 1, 2);//razdelq bukvite
            return chars;
        }
    }
}
