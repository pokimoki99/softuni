using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3.__Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split('\\', StringSplitOptions.RemoveEmptyEntries);
            var file = input[input.Length - 1].Split('.', StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine($"File name: {file[0]}");
            Console.WriteLine($"File extension: {file[1]}");
        }
    }
}
