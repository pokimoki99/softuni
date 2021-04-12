using System;
using System.Numerics;

namespace _11.Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            byte numOfSnowballs = Byte.Parse(Console.ReadLine());
            BigInteger higestValue = int.MinValue;
            short highestSnow = 0;
            short highestTime = 0;
            byte highestQuality = 0;
            for (int i = 0; i < numOfSnowballs; i++)
            {
                short snowBallSnow = short.Parse(Console.ReadLine());
                short snowBallTime = short.Parse(Console.ReadLine());
                byte snowBallQuality = byte.Parse(Console.ReadLine());
                BigInteger snowBallValue = BigInteger.Pow((snowBallSnow / snowBallTime), snowBallQuality);
                if (snowBallValue > higestValue)
                {
                    higestValue = snowBallValue;
                    highestSnow = snowBallSnow;
                    highestTime = snowBallTime;
                    highestQuality = snowBallQuality;
                }
            }
            Console.WriteLine($"{highestSnow} : {highestTime} = {higestValue} ({highestQuality})");
        }
    }
 }
