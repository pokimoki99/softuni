﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Sum_Adjacent_Equal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split().Select(double.Parse).ToList();
            for (int i = 1; i < ; i++)
            {

            }
            if (numbers[i] == numbers[i + 1])
            {
                numbers[i] += numbers[i + 1];
                numbers.RemoveAt(i + 1);
                i = _1;
            }
        }
    }
}
