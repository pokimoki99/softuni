using System;

namespace _03._New_House
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfFlowers = Console.ReadLine();
            int numOfFlowers = int.Parse(Console.ReadLine());
            int bujet = int.Parse(Console.ReadLine());
            double price = 0.00;
            double discount;
            double moreUp;
            switch (typeOfFlowers)
            {
                case "Roses":
                    price = numOfFlowers * 5;
                    if (numOfFlowers> 80 )
                    {
                        discount = price * 0.1;
                        price -= discount;
                    }
                    break;
                case "Dahlias":
                    price = numOfFlowers * 3.80;
                    if (numOfFlowers > 90)
                    {
                        
                        discount = price * 0.15;
                        price -= discount;
                      
                    }
                    break;
                case "Tulips":
                    price = numOfFlowers * 2.80;
                    if (numOfFlowers > 80)
                    {
                        discount = price * 0.15;
                        price -= discount;
                    }
                    break;
                case "Narcissus":
                    price = numOfFlowers * 3;
                    if (numOfFlowers < 120)
                    {
                        moreUp = price * 0.15;
                        price += moreUp;
                    }
                    break;
                case "Gladiolus":
                    price = numOfFlowers * 2.50;
                    if (numOfFlowers < 80)
                    {
                        moreUp = price * 0.2;
                        price += moreUp;
                    }
                    break;
            }
            if (bujet >= price)
            {
                Console.WriteLine($"Hey, you have a great garden with {numOfFlowers} {typeOfFlowers} and {(bujet-price):f2} leva left.");

            }
            else
            {
                Console.WriteLine($"Not enough money, you need {(price-bujet):f2} leva more.");
            }
        }
    }
}
