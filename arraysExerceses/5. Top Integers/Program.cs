using System;
using System.Linq;

namespace _5._Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program to find all the top integers in an array.
            //A top integer is an integer which is bigger than all the elements to its right. 
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            bool isBigger = true;
            for (int i = 0; i < array.Length; i++)
            {
                int curr = array[i];
                for (int j = i+1; j < array.Length; j++)
                {
                    if (array[j]>= curr)
                    {
                        isBigger = false;
                        break;
                    }

                }
                if (isBigger)
                {
                    Console.Write(curr + " ");
                }
                isBigger = true;
            }
        }
    }
}


