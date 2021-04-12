using System;

namespace _12._Trade_Commissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double volumeOfSale = double.Parse(Console.ReadLine());
            double sale = 0;
            if (0 <= volumeOfSale && volumeOfSale <= 500)
            {
                if (city == "Sofia")
                {
                    sale = volumeOfSale * 0.05;
                    Console.WriteLine($"{sale:f2}");
                }
                else if (city == "Varna")
                {
                    sale = volumeOfSale * 0.045;
                    Console.WriteLine($"{sale:f2}");
                }
                else if (city == "Plovdiv")
                {
                    sale = volumeOfSale * 0.055;
                    Console.WriteLine($"{sale:f2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (500 < volumeOfSale && volumeOfSale <= 1000)
            {

                if (city == "Sofia")
                {
                    sale = volumeOfSale * 0.07;
                    Console.WriteLine($"{sale:f2}");
                }
                else if (city == "Varna")
                {
                    sale = volumeOfSale * 0.075;
                    Console.WriteLine($"{sale:f2}");
                }
                else if (city == "Plovdiv")
                {
                    sale = volumeOfSale * 0.08;
                    Console.WriteLine($"{sale:f2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (1000 < volumeOfSale && volumeOfSale <= 10000)
            {

                if (city == "Sofia")
                {
                    sale = volumeOfSale * 0.08;
                    Console.WriteLine($"{sale:f2}");
                }
                else if (city == "Varna")
                {
                    sale = volumeOfSale * 0.1;
                    Console.WriteLine($"{sale:f2}");
                }
                else if (city == "Plovdiv")
                {
                    sale = volumeOfSale * 0.12;
                    Console.WriteLine($"{sale:f2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (volumeOfSale > 10000)
            {

                if (city == "Sofia")
                {
                    sale = volumeOfSale * 0.12;
                    Console.WriteLine($"{sale:f2}");
                }
                else if (city == "Varna")
                {
                    sale = volumeOfSale * 0.13;
                    Console.WriteLine($"{sale:f2}");
                }
                else if (city == "Plovdiv")
                {
                    sale = volumeOfSale * 0.145;
                    Console.WriteLine($"{sale:f2}");
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


