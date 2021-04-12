using System;

namespace Gauss2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split().Select(double.Parse).ToList();
            int maxIndex = numbers.Count / 2;
            for (int i = 0; i < maxIndex; i++)
            {
                numbers[i] += numbers[numbers.Count - 1];//vzima posledniq element
                numbers.Remove(numbers[numbers.Count - 1]);//sled tova go premahva
            }
            //da si go printiram
        }
    }
}
