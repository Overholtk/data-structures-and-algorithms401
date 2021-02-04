using System;
using System.Text;

namespace LinkedLists
{
    public class Stack<T>
    {
        public Node<T> top { get; set; }


        public bool peek()
        {
            return top != null;
        }

        public void Push(T value)
        {
            Node<T> node = new Node<T>(value);
            node.Next = top;
            top = node;
        }

        public Node<T> pop()
        {
            Node<T> currentTop = top;
            top = currentTop.Next;
            currentTop.Next = null;
            return currentTop;

        }

        public bool isEmpty()
        {
            return top == null;
        }
    }

}
