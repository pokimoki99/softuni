﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;

namespace ListLab
{
    class Program
    {
        static void Main(string[] args)
        {

            List<double> num = Console.ReadLine()
                 .Split()
                 .Select(double.Parse)
                 .ToList();
            for (int i = 0; i <= num.Count; i++)
            {
                if (num[i] == num[i + 1])
                {
                    num[i] += num[i + 1];
                    num.RemoveAt(i + 1);
                    i = -1;//!!!!!!!!

                }
            }
            Console.WriteLine(String.Join(" ", num));
        }
    }
}
