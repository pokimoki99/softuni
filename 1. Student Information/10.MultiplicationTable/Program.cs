﻿using System;
using System.ComponentModel.DataAnnotations;

namespace _10.MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var times = 1;
            while (times <= 10)
            {
                Console.WriteLine($"{number} X {times} = {number * times}");
                times++;
            }

        }
    }
}

