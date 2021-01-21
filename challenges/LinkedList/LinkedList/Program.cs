using System;


namespace LinkedLists
{
    class Program
    {
        static void Main(string[] args)
        {

            LinkedList myList = new LinkedList();

            myList.Insert(4);
            myList.Insert(3);
            myList.Insert(2);
            myList.Insert(1);

            LinkedList listA = new LinkedList();

            listA.Insert(8);
            listA.Insert(7);
            listA.Insert(6);
            listA.Insert(5);

            Console.WriteLine(LLzip.zip(myList, listA).Value);
            //Console.WriteLine(myList.kthFromEnd(5));
            //Console.WriteLine(myList.toString());
            //Console.Write(myList.Includes(50));

        }

    }
}
