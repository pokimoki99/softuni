using System;

namespace _3.Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfPeople = int.Parse(Console.ReadLine());
            int capasity = int.Parse(Console.ReadLine());
            int courses = (int)Math.Ceiling(numOfPeople / (double)capasity);
            Console.WriteLine(courses);    
        }
    }
}
