using System;

namespace LinkedLists
{
        public class Node<T>
        {
            public T Value { get; set; }
            public Node<T> Next { get; set; }

            //Constructor
            public Node(T value)
            {
                Value = value;
            }
        }
}
