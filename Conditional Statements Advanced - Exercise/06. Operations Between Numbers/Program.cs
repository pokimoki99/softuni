using System;

namespace _06._Operations_Between_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            string operatorr = Console.ReadLine();
            double result = 0.0;
            string resultPrint = "";
            switch (operatorr)
            {
                case ("+"):
                    result = num1 + num2;
                    if (result % 2 == 0)
                    {
                        resultPrint = $"{num1} {operatorr} {num2} = {result} - even";
                    }
                    else
                    {
                        resultPrint = $"{num1} {operatorr} {num2} = {result} - odd";
                    }
                    break;
                case ("-"):
                    result = num1 - num2;
                    if (result % 2 == 0)
                    {
                        resultPrint = $"{num1} {operatorr} {num2} = {result} - even";
                    }
                    else
                    {
                        resultPrint = $"{num1} {operatorr} {num2} = {result} - odd";
                    }
                    break;
                case ("*"):
                    result = num1 * num2;
                    if (result % 2 == 0)
                    {
                        resultPrint = $"{num1} {operatorr} {num2} = {result} - even";
                    }
                    else
                    {
                        resultPrint = $"{num1} {operatorr} {num2} = {result} - odd";
                    }
                    break;
                case ("/"):
                    if (num2 == 0)
                    {
                        resultPrint = $"Cannot divide {num1} by zero";
                    }
                    else
                    {
                        result = (double)num1 / num2;
                        resultPrint = $"{num1} / {num2} = {result:F2}";
                    }
                    break;
                case ("%"):
                 
                    if (num2 == 0)
                    {
                        resultPrint = $"Cannot divide {num1} by zero";
                    }
                    else
                    {
                        result = (double)num1 % num2;
                        resultPrint = $"{num1} {operatorr} {num2} = {result}";
                    }
                    break;
            }
            Console.WriteLine(resultPrint);

        }
    }
}
