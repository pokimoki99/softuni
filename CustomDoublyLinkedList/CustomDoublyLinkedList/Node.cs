using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    class Node
    {
        public Node(int value)
        {
            Value = value;
            //Next = next;
        }
        public int Value { get; set; }
        public Node Next { get; set; }
        public Node Previous { get; set; }
    }
}
