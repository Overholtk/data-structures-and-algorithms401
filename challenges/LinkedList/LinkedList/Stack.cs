using System;
using System.Collections.Generic;
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

        public void push(T value)
        {
            Node<T> node = new Node<T>(value);
            node.Next = top;
            top = node;
        }

        public Node<T> pop()
        {
            Node<T> currentTop = top;
            top = currentTop.Next;
            return currentTop;

        }

        public bool isEmpty()
        {
            return top == null;
        }
    }

}
