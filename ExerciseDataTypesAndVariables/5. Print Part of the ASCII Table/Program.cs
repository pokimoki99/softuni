using System;

namespace _5._Print_Part_of_the_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int step = 1;
            int number = start;
            if (start > end)
            {
                int temp = start;
                start = end;
                end = temp;
                step = -1;
            }
            string result = "";
           
            for (int i = start; i <= end; i+= step)
            {
                result += (char)number + " ";
                number += step; 
            }
            Console.WriteLine(result);
        }
    }
}
