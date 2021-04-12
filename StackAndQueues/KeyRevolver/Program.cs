using System;
using System.Collections.Generic;
using System.Linq;

namespace KeyRevolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int bulletPrice = int.Parse(Console.ReadLine());
            int gunBarrelZize = int.Parse(Console.ReadLine());
            int[] bulletsInput = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            Stack<int> bullets = new Stack<int>(bulletsInput);
            int[] locksInput = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            Queue<int> locks = new Queue<int>(bulletsInput);
            int intelligenceVallue = int.Parse(Console.ReadLine());
            int bulletsCount = 0;
            int currentBarrelSize = gunBarrelZize; 
            while (bullets.Any() && locks.Any())
            {
               
                bulletsCount++;
                currentBarrelSize--;
                int currentNullet = bullets.Pop();
                int currentLock = locks.Peek();
                if (currentNullet <= currentLock)
                {
                    Console.WriteLine("Bang!");
                    locks.Dequeue();
                }
                else
                {
                    Console.WriteLine("Ping!");
                }
                if (currentBarrelSize == 0 && bullets.Any())
                {
                    currentBarrelSize = gunBarrelZize;
                    Console.WriteLine("Reloading!");
                }
            }
            if (!locks.Any())
            {
                int moneyEarned = intelligenceVallue - (bulletsCount * bulletPrice);
                Console.WriteLine($"{bulletsCount} bullets left. Earned ${moneyEarned}");
            }
            else
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
            }
        }
    }
}
