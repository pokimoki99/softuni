using System;
using System.Collections.Generic;
using System.Linq;

namespace _8.Anonymous_Threat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> data = Console.ReadLine()
                .Split()
                .ToList();
            string input = Console.ReadLine();
            while (input != "3:1")
            {
                string[] commandElement = input.Split();
                string command = commandElement[0];
                if (command == "merge")
                {
                    int startIndex = int.Parse(commandElement[1]);
                    int endIndex = int.Parse(commandElement[2]);
                    string concatDate = string.Empty;
                    if (startIndex < 0)
                    {
                        if (endIndex >= 0 && endIndex <= data.Count - 1)
                        {
                            startIndex = 0;
                        }
                    }
                    if (endIndex > data.Count - 1)
                    {
                        if (startIndex >= 0 && startIndex <= data.Count - 1)
                        {
                            endIndex = data.Count - 1;
                        }

                    }
                    //if (endIndex < data.Count)
                    //{
                    //    if (startIndex < 0)
                    //    {
                    //        startIndex = 0;
                    //    }
                    //}

                    //if (startIndex >= 0)
                    //{
                    //    if (endIndex > data.Count - 1)
                    //    {
                    //        endIndex = data.Count - 1;
                    //    }
                    //}
                    for (int i = startIndex; i <= endIndex; i++)
                    {
                        concatDate += data;
                    }
                   
                    
                    data.RemoveRange(startIndex, endIndex - startIndex + 1);
                    data.Insert(startIndex, concatDate);

                }
                else if (command == "divide")
                {
                    int index = int.Parse(commandElement[1]);
                    int partition = int.Parse(commandElement[2]);
                    string word = data[index];
                    List<string> divideWord = new List<string>();
                    int strigLenghtToAdd = word.Length / partition;
                    int startIndex = 0;
                    for (int i = 0; i < partition; i++)
                    {
                        if (i == partition - 1)
                        {
                            divideWord.Add(word.Substring(startIndex, word.Length - startIndex))
;                       }
                        else
                        {
                            divideWord.Add(word.Substring(startIndex, strigLenghtToAdd));
                            startIndex += strigLenghtToAdd;
                        }
                       
                    }
                    data.RemoveAt(index);
                    data.InsertRange(index, divideWord);
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(String.Join(" ",data));

        }
    }
}
