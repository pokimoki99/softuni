using System;
using System.Collections.Generic;

namespace _7.HotPotato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] children = Console.ReadLine().Split();
            int n = int.Parse(Console.ReadLine());
            Queue<string> potatoQueue = new Queue<string>(children);
            int potatoToses = 0;
            while (potatoQueue.Count > 1)
            {
                potatoToses++;
                string kid = potatoQueue.Dequeue();
                if (potatoToses == n)
                {
                    potatoToses = 0;
                    Console.WriteLine("Removed " + kid);
                }
                else
                {
                    potatoQueue.Enqueue(kid);
                }
            }
            Console.WriteLine("Last is " + potatoQueue.Dequeue());
        }
    }
}
