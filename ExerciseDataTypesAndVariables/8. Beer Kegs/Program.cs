using System;
using System.Numerics;

namespace _8._Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {//π * r^2 * h. 
            int n = int.Parse(Console.ReadLine());
            float maxVolume = float.MinValue;
            string biggestModel = "";
            for (int i = 0; i < n; i++)
            {
                string model = Console.ReadLine();
                float radios = float.Parse(Console.ReadLine());
                int hight = int.Parse(Console.ReadLine());
                float  volume =(float) (Math.PI * Math.Pow(radios, 2) * hight);
                if (volume > maxVolume)
                {
                    maxVolume = volume;
                    biggestModel = model;
                }

            }
            Console.WriteLine(biggestModel);
        }
    }
}
