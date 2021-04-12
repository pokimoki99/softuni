using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4.CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string encripted = String.Empty;
            for (int i = 0; i < text.Length; i++)
            {
                encripted += (char)(text[i] + 3);
            }
            Console.WriteLine(encripted);
        }
    }
}
