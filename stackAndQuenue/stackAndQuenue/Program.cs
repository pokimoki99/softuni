using System;
using System.Collections.Generic;
using System.Linq;


namespace stackAndQuenue
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> reveredStack = new Stack<char>();
            for (int i = 0; i < input.Length; i++)
            {
                reveredStack.Push(input[i]);
            }
            while (reveredStack.Count > 0)
            {
                Console.Write(reveredStack.Pop());
            }
            Console.WriteLine();
            
        }
    }
}
