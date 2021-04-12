using System;

namespace YardGreening
{
    class Program
    {
        static void Main(string[] args)
        {
            double area = double.Parse(Console.ReadLine());
            double price = area * 7.61;
            double discount = 0.18 * price;
            double finalPrice = price - discount;
            Console.WriteLine($"The final price is: {finalPrice:f2} lv.");
            Console.WriteLine($"The discount is: {discount:f2} lv.");
        }
    }
}
