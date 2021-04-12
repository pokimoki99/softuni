using System;
using System.Collections.Generic;

namespace _2._AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> output = new Dictionary<string, int>();
            string resurses = Console.ReadLine();
            while (resurses != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());
                if (!output.ContainsKey(resurses))
                {
                    output.Add(resurses, 0);
                }
                output[resurses] += quantity;
                resurses = Console.ReadLine();
            }
            foreach (var item in output)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
