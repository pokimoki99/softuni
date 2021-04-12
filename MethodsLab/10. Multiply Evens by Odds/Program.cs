using System;

namespace _10._Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            n = Math.Abs(n);
            MultyPlayEvenOddSum(n);
        }
        static int CalculateOddDiggitSum(int n, int isOdd)
        {
            string number = n.ToString();
            int sum = 0;
            for (int i = 0; i < number.Length; i++)
            {
                int currentDiggit = int.Parse(number[i].ToString());
                if (currentDiggit % 2 == isOdd)
                {
                    sum += currentDiggit;
                }
            }
            return sum;
        }
        static int MultyPlayEvenOddSum(int n)
        {
            return CalculateOddDiggitSum(n, 0) * CalculateOddDiggitSum(n, 1);
        }
    }
}
