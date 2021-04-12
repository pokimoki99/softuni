using System;

namespace CustomTuple
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string[] firstTupleData = Console.ReadLine().Split(" ");
            string fullName = $"{firstTupleData[0]} {firstTupleData[1]}";
            MyTuple<string, string> firstTuple = new MyTuple<string, string>(fullName, firstTupleData[2]);

                string[] secondTupleData = Console.ReadLine().Split(" ");
            MyTuple<string, int> secondTuple = new MyTuple<string, int>(secondTupleData[0], int.Parse(secondTupleData[1]));


            string[] thurdTupleData = Console.ReadLine().Split(" ");
            MyTuple<int, double> thurdTuple = new MyTuple<int, double>(int.Parse(thurdTupleData[0]), double.Parse(thurdTupleData[1]));

            Console.WriteLine(firstTuple);
            Console.WriteLine(secondTuple);
            Console.WriteLine(thurdTuple);

        }
    }
}
