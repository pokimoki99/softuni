using System;

namespace _9._Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            if (type == "int")
            {
                int first = int.Parse(Console.ReadLine());
                int second = int.Parse(Console.ReadLine());
                Console.WriteLine(GetBigger(first, second));
            }
            if (type == "char")
            {
                char first = char.Parse(Console.ReadLine());
                char second = char.Parse(Console.ReadLine());
                Console.WriteLine(GetBigger(first, second));
            }
            if (type == "string")
            {
                string first = Console.ReadLine();
                string second =Console.ReadLine();
                Console.WriteLine(GetBigger(first, second));
            }
        }
        static int GetBigger(int First, int second)
        {
            int compare = First.CompareTo(second);
            if (compare > 0)
            {
                return First;
            }
            else
            {
                return second;
            }
        }
        static char GetBigger(char First, char second)
        {
            int compare = First.CompareTo(second);
            if (compare > 0)
            {
                return First;
            }
            else
            {
                return second;
            }
        }
        static string GetBigger(string First, string second)
        {
            int compare = First.CompareTo(second);
            if (compare > 0)
            {
                return First;
            }
            else
            {
                return second;
            }
        }
    }
}
