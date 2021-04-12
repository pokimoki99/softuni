using System;

namespace _5._Login
{
    class Program
    {
        static void Main(string[] args)
        {
           string username = Console.ReadLine();
            string pass = "";
            for (int i = username.Length - 1; i >= 0; i--)
			{
                 pass += username[i];
			}

            string input = Console.ReadLine();
            double counter = 1;
            while (input != pass)
	        {
                if (counter == 4)
	            {
                Console.WriteLine($"User {username} blocked! ");
                break;
	            }
                Console.WriteLine($"Incorrect password. Try again.");
                input = Console.ReadLine();
                counter++;

	        }
                if (input == pass)
	            {
                Console.WriteLine($"User {username} logged in.");
	            }
        }
    }
}
