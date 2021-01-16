using System;

namespace LinkedLists
{
        public class LinkedList
        {

            public Node Head { get; set; }

            public LinkedList() { }

            public void Insert(int value)
            {
                Node node = new Node(value);
                node.Next = Head;
                Head = node;
            }

            public bool Includes(int value)
            {
                Node current = Head;
                bool valueFound = false;
                while (current != null)
                {
                    if(current.Value == value)
                    {
                        valueFound = true;
                    }
                    current = current.Next;
                }
                return valueFound;
            }

            public string toString()
            {
                Node current = Head;
                string allValues = "";
                while(current != null)
                {
                    allValues += ($"{current.Value} => ");
                    current = current.Next;
                }
                allValues += ("NULL");
            return allValues;
            }
        }
}
