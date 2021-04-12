using System;

namespace _10._Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGamesCount = int.Parse(Console.ReadLine());
            double headSetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyBoardtPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());
            double rageExpences = 0;
            for (int i = 1; i <= lostGamesCount; i++)
            {
                if (i % 2 == 0)
                {
                    rageExpences += headSetPrice;
                }
                if (i % 3 == 0)
                {
                    rageExpences += mousePrice;
                }
                if (i % 6 == 0)
                {
                    rageExpences += keyBoardtPrice;
                }
                if (i % 12 == 0)
                {
                    rageExpences += displayPrice;
                }
            }
            Console.WriteLine($"Rage expenses: {rageExpences:f2} lv.");
        }
    }
}
