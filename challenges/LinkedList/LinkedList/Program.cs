using System;

namespace LinkedLists
{
    class Program
    {
        static void Main(string[] args)
        {

            LinkedList myList = new LinkedList();

            myList.Insert(1);
            myList.Insert(2);
            myList.Insert(3);
            myList.Insert(4);
            Console.WriteLine(myList.kthFromEnd(5));
            Console.WriteLine(myList.toString());
            Console.Write(myList.Includes(50));

        }

    }
}
