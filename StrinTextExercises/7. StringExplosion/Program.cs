using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _7._StringExplosion
{
    class Program
    {
        static void Main(string[] args)
        {
            var filed = Console.ReadLine();
            int bomb = 0;
            for (int i = 0; i < filed.Length; i++)
            {
                var currentChar = filed[i];
                if (currentChar == '>')
                {
                    bomb += int.Parse(filed[i + 1].ToString());
                    continue;
                }
                if (bomb > 0)
                {
                    filed = filed.Remove(i, 1);
                    i--;
                    bomb--;
                }
            }
            Console.WriteLine(filed);
        }
    }
}
