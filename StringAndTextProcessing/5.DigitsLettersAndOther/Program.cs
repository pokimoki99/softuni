
using System;
using System.Text;

namespace _5.DigitsLettersAndOther
{
    class Program
    {

        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            StringBuilder digit = new StringBuilder();
            StringBuilder letters = new StringBuilder();
            StringBuilder others = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsDigit(text[i]))
                {
                    digit.Append(text[i]);
                }
                else if (char.IsLetter(text[i]))
                {
                    letters.Append(text[i]);
                }
                else 
                {
                    others.Append(text[i]);
                }
            }
            Console.WriteLine(digit);
            Console.WriteLine(letters);
            Console.WriteLine(others);
          
        }
    }
}
