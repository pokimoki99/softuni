﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _6.ReplaceRepeatingChars
{
    class Program
    {
        static void Main(string[] args)
        {
            var sb = new StringBuilder();
            var input = Console.ReadLine().ToCharArray();
            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input[i] != input[i + 1])
                {
                    sb.Append(input[i]);
                }
            }
            var symbol = input[input.Length - 1];
            sb.Append(symbol);
            Console.WriteLine(sb.ToString());
        }
    }
}
