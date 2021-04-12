using System;

namespace Conditional_Statements_Advanced___Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfProjection = Console.ReadLine();
            int numOfLine = int.Parse(Console.ReadLine());
            int numOfcoluns = int.Parse(Console.ReadLine());
            double income = 0.0;
            if (typeOfProjection =="Premiere" )
            {
                income = numOfcoluns * numOfLine * 12;
            }
            else if (typeOfProjection == "Normal")
            {
                income = numOfcoluns * numOfLine * 7.50;
            }
            else if (typeOfProjection == "Discount")
            {
                income = numOfcoluns * numOfLine * 5;
            }
            Console.WriteLine($"{income:f2} leva");
        }
    }
}
