using System;

namespace InchesToSantimetres
{
    class Program
    {
        static void Main(string[] args)
        {
            double inches = double.Parse(Console.ReadLine());
            double sum = inches * 2.54;
            Console.WriteLine(sum);
        }
    }
}
