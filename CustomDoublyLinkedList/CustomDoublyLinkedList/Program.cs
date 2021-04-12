using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Node node = new Node(1);
            SoftuniLinkedList linkedList = new SoftuniLinkedList();
            for (int i = 0; i < 20; i++)
            {
                linkedList.AddHead(new Node(i));
            }
            var currentNode = linkedList.Tail;
            while(currentNode != null)
            {
                Console.WriteLine(currentNode.Value);
                currentNode = currentNode.Previous;
            }
        }
    }
}
