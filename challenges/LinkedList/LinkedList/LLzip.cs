using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedLists
{
    public class LLzip
    {
        public static Node zip(LinkedList listA, LinkedList listB)
        {

            Node A = listA.Head;
            Node B = listB.Head;
            Node C;
            while (B.Next != null || A.Next != null)
            {
                C = B.Next;
                B.Next = A.Next;
                A.Next = B;
                A = B.Next;
                B = C;
            }

            return listA.Head;
        }
    }
}
