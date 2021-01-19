﻿using System;

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

        public int append(int value)
        {
            Node currentNode = Head;
            while(currentNode.Next != null)
            {
                currentNode = currentNode.Next;
            }
            Node newNode = new Node(value);
            currentNode.Next = newNode;
            return newNode.Value;
        }

        public int insertBefore(int value, int newVal)
        {
            Node currentNode = Head;
            Node previousNode = Head;
            while(currentNode != null)
            {
                if(currentNode.Value == newVal)
                {
                    Node newNode = new Node(newVal);
                    previousNode.Next = newNode;
                    newNode.Next = currentNode;
                    break;
                }
                previousNode = currentNode;
                currentNode = currentNode.Next;
            }
            return currentNode.Value;
        }

        public int insertAfter(int value, int newVal)
        {
            Node current = Head;
            Node newNode = new Node(value);
            while(current != null)
            {
                if(current.Value == value)
                {
                    newNode.Next = current.Next;
                    current.Next = newNode;
                    break;
                }
                current = current.Next;
            }
            return newNode.Value;
        }
    }
}