using System;
using System.ComponentModel;

namespace _3._Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string comand = Console.ReadLine();
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            switch (comand)
            {case"add";
                    Add(a, b);
                default:
                    break;
            }
        }
    }
}
