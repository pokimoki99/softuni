using System;

namespace ExerciseDataTypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            int numFirst = int.Parse(Console.ReadLine());
            int numSecond = int.Parse(Console.ReadLine());
            int numThird = int.Parse(Console.ReadLine());
            int numFourth = int.Parse(Console.ReadLine());
            Console.WriteLine((numFirst + numSecond) / numThird * numFourth);
        }
    }
}
