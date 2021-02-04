using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedLists
{
    public class LLzip
    {
        public static Node<int> zip(LinkedList<int> listA, LinkedList<int> listB)
        {

            Node<int> A = listA.Head;
            Node<int> B = listB.Head;
            Node<int> C;
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
