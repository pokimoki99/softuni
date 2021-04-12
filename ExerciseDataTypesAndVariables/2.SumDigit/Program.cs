using System;
using System.Security;

namespace _2.SumDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            // string num = Console.Readline();
            // int sum =0;
            // for(int i = 0; i < num.Lenght; i++)
           // {
           //   sum+= int.Parse(num[i].ToString()); 
            //}
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            while (num != 0)
            {
                sum += num % 10;
                num /= 10;
            }
            Console.WriteLine(sum);
        }
    }
}
