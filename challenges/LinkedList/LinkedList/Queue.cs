using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedLists
{
    class Queue<T>
    {
        public Node<T> front { get; set; }

        public void enqueue(T value)
        {
            Node<T> node = new Node<T>(value);
            node.Next = front;
            front = node;
        }

        public Node<T> dequeue()
        {
            Node<T> currentFront = front;
            front = currentFront.Next;
            currentFront.Next = null;
            return currentFront;
        }

        public T peek()
        {
            return front.Value;
        }

        public bool isEmpty()
        {
            return front != null;
        }

    }
}
