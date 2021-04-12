using System;
using System.Linq;

namespace ObjectAndClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(AdvertMessages.GenerateMessage());
            }

        }
        public class AdvertMessages
        {
            public static string[] Phrazes = new string[]
            {
                "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product."
            };
            public static string[] Events = new string[]
                {
        "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!"
                 };
            public static string[] Authors = new string[]
               {
                "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"
                };
            public static string[] Cities = new string[]
            {
        "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"
             };
            public static string GenerateMessage()
            {
                Random rand = new Random();
                string currentPhrazes = Phrazes[rand.Next(0, Phrazes.Length - 1)];
                string currentEvents = Events[rand.Next(0, Events.Length - 1)];
                string currentAuthosrs = Authors[rand.Next(0, Authors.Length - 1)];
                string currentCities = Cities[rand.Next(0, Cities.Length - 1)];
                return $" {currentPhrazes} {currentEvents} {currentAuthosrs} – {currentCities}.";

            }
        }
    }
}
