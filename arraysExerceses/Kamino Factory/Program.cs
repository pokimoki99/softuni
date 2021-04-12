using System;
using System.Linq;

namespace Kamino_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            string input = String.Empty;
            int counter = 0;
            int bestCount = 0;
            int besBegin = 0;
            int bestSum = 0;
            int bestSinquense = 0;
           
            while ((input = Console.ReadLine())!= "Clone them!")
            {
                string sequences = input.Replace("!", "");
                string[] dnaParts = sequences.Split("0", StringSplitOptions.RemoveEmptyEntries);
                int count = 0;
                int sum = 0;
                string bestSubs = "";
                counter++;
                foreach (string dnaPart in dnaParts)
                {
                    if (dnaPart.Length > count)
                    {
                        count = dnaPart.Length;
                        bestSubs = dnaPart;
                    }
                    sum += dnaPart.Length;
                }
                int beginIndex = sequences.IndexOf(bestSubs);
                if (count > bestCount ||(count == bestCount && beginIndex< besBegin)||(count == bestCount && beginIndex == besBegin && sum > bestSum))
                {
                    bestCount = count;
                    bestSinquense = sequences;
                    besBegin = beginIndex;
                    bestSum = sum;
                    bestCount = counter;
                }
            }
            char[] result = bes
            Console.WriteLine($"Best DNA sample {bestCount} with sum: {bestSum}.");
            Console.WriteLine(String.Join(" ", dn));

        }

    }
}
