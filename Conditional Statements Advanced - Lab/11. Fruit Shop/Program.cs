using System;

namespace _11._Fruit_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string dayOfTheWeek = Console.ReadLine();
            double quanty = double.Parse(Console.ReadLine());
            double price = 0.0;
            if (dayOfTheWeek == "Monday" || dayOfTheWeek == "Tuesday" || dayOfTheWeek == "Wednesday" || dayOfTheWeek == "Thursday" || dayOfTheWeek == "Friday")
            {
                if (fruit == "banana")
                {
                    price = quanty * 2.50;
                    Console.WriteLine($"{price:f2}");
                }
                 else if(fruit == "apple")
                {
                    price = quanty * 1.20;
                    Console.WriteLine($"{price:f2}");
                }
                else if (fruit == "orange")
                {
                    price = quanty *0.85;
                    Console.WriteLine($"{price:f2}");
                }
                else if (fruit == "grapefruit")
                {
                    price = quanty * 1.20;
                    Console.WriteLine($"{price:f2}");
                }
                else if (fruit == "kiwi")
                {
                    price = quanty * 2.70;
                    Console.WriteLine($"{price:f2}");
                }
                else if (fruit == "pineapple")
                {
                    price = quanty *5.50;
                    Console.WriteLine($"{price:f2}");
                }
                else if (fruit == "grapes")
                {
                    price = quanty * 3.85;
                    Console.WriteLine($"{price:f2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (dayOfTheWeek == "Saturday" || dayOfTheWeek == "Sunday")
            {
                 if (fruit == "banana")
                {
                    price = quanty * 2.70;
                    Console.WriteLine($"{price:f2}");
                }
                else if (fruit == "apple")
                {
                    price = quanty * 1.25;
                    Console.WriteLine($"{price:f2}");
                }
                else if (fruit == "orange")
                {
                    price = quanty * 0.90;
                    Console.WriteLine($"{price:f2}");
                }
                else if (fruit == "grapefruit")
                {
                    price = quanty * 1.60;
                    Console.WriteLine($"{price:f2}");
                }
                else if (fruit == "kiwi")
                {
                    price = quanty * 3.00;
                    Console.WriteLine($"{price:f2}");
                }
                else if (fruit == "pineapple")
                {
                    price = quanty * 5.60;
                    Console.WriteLine($"{price:f2}");
                }
                else if (fruit == "grapes")
                {
                    price = quanty * 4.20;
                    Console.WriteLine($"{price:f2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else
            {
                Console.WriteLine("error");
            }

        }
    }
}
