using System;

namespace MethodsExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();
            VowelsCount(text);

        }
        static void VowelsCount(string text)//chete glasnite
        {
            int vowelsCounter = 0;//broiach
            for (int i = 0; i < text.Length; i++)
            {
                switch (text[i])
                {
                    case 'a':
                        vowelsCounter++;
                        break;
                    case 'e':
                        vowelsCounter++;
                        break;
                    case 'i':
                        vowelsCounter++;
                        break;
                    case 'o':
                        vowelsCounter++;
                        break;
                    case 'u':
                        vowelsCounter++;
                        break;
                }
            }
            Console.WriteLine(vowelsCounter);
        }
    }
}
