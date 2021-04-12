using System;

namespace ProjectCreation
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameOfTheArhitect = Console.ReadLine();
            int numOfProject = int.Parse(Console.ReadLine());
            int total = numOfProject * 3;
            Console.WriteLine($"The architect {nameOfTheArhitect} will need {total} hours to complete {numOfProject} project/s.");

        }
    }
}
