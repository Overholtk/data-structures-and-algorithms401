using System;
using System.Collections.Generic;

namespace LinkedLists
{
    public class LinkedList<T>
        {

        public Node<T> Head { get; set; }

        public LinkedList() { }

        public void Insert(T value)
            {
                Node<T> node = new Node<T>(value);
                node.Next = Head;
                Head = node;
            }

        public bool Includes(int value)
            {
                Node<T> current = Head;
                bool valueFound = false;
                while (current != null)
                {
                    if(current.Value.Equals(value))
                    {
                        valueFound = true;
                    }
                    current = current.Next;
                }
                return valueFound;
            }

        public string toString()
            {
                Node<T> current = Head;
                string allValues = "";
                while(current != null)
                {
                    allValues += ($"{current.Value} => ");
                    current = current.Next;
                }
                allValues += ("NULL");
            return allValues;
            }

        public T append(T value)
        {
            Node<T> currentNode = Head;
            while(currentNode.Next != null)
            {
                currentNode = currentNode.Next;
            }
            Node<T> newNode = new Node<T>(value);
            currentNode.Next = newNode;
            return newNode.Value;
        }

        public T insertBefore(T value, T newVal)
        {
            Node<T> currentNode = Head;
            Node<T> previousNode = Head;
            while(currentNode != null)
            {
                if(currentNode.Value.Equals(newVal))
                {
                    Node<T> newNode = new Node<T>(newVal);
                    previousNode.Next = newNode;
                    newNode.Next = currentNode;
                    break;
                }
                previousNode = currentNode;
                currentNode = currentNode.Next;
            }
            return currentNode.Value;
        }

        public T insertAfter(T value, T newVal)
        {
            Node<T> current = Head;
            Node<T> newNode = new Node<T>(value);
            while(current != null)
            {
                if(current.Value.Equals(value))
                {
                    newNode.Next = current.Next;
                    current.Next = newNode;
                    break;
                }
                current = current.Next;
            }
            return newNode.Value;
        }

        public T kthFromEnd(int value)
        {
            if(value < 0) { throw new ArgumentException("Try again with a positive value!");}
            int counter = 1;
            Node<T> node = Head;
            while(node != null)
            {
                counter++;
            }
            int index = counter - value;
            if( index < 0) { throw new Exception("Value was longer than the length of the list"); }
            if(index == 0) { index = 1; }
            node = Head;
            for(int i = 1; i < index; i++)
            {
                node = node.Next;
            }

            return node.Value;

        }

        public LinkedList<T> zip(LinkedList<T> listA, LinkedList<T> listB)
        {
            Node<T> A = listA.Head;
            Node<T> B = listB.Head;
            Node<T> C;
            while(A.Next != null && B.Next != null)
            {
                C = B.Next;
                B.Next = A.Next;
                A.Next = B;
                A = B.Next;
                B = C;
            }

            return listA;
        }
    }
}
