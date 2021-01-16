using System;
using Xunit;
using LinkedLists;

namespace LinkedListTests
{
    public class UnitTest1
    {
        [Fact]
        public void Linked_List_Created_Empty()
        {
            LinkedList testList = new LinkedList();
            Assert.Null(testList.Head);
        }

        [Fact]
        public void Insert_Into_Head()
        {
            LinkedList testList = new LinkedList();
            testList.Insert(3);
            Assert.Equal(3, testList.Head.Value);
        }

        [Fact]
        public void Check_Head_Value()
        {
            LinkedList testList = new LinkedList();
            testList.Insert(3);
            testList.Insert(15);
            testList.Insert(420);

            Assert.Equal(420, testList.Head.Value);
        }

        [Fact]
        public void Check_Multiple_Nodes()
        {
            LinkedList testList = new LinkedList();
            testList.Insert(3);
            testList.Insert(15);
            testList.Insert(420);

            Node currentNode = testList.Head;
            for(var i = 0; i < 2; i++)
            {
                Assert.NotNull(currentNode);
                currentNode = currentNode.Next;
            }
        }

        [Fact]
        public void Value_Does_Exist()
        {
            LinkedList testList = new LinkedList();
            testList.Insert(50);
            testList.Insert(2);
            Assert.True(testList.Includes(2));

        }

        [Fact]
        public void Value_Does_Not_Exist()
        {
            LinkedList testList = new LinkedList();
            testList.Insert(50);
            testList.Insert(2);
            Assert.False(testList.Includes(420));

        }

        [Fact]
        public void Return_All_Values()
        {
            LinkedList testList = new LinkedList();
            testList.Insert(50);
            testList.Insert(2);
            testList.Insert(4000);

            string testString = testList.toString();
            Assert.Equal("4000 => 2 => 50 => NULL", testString);
            
        }
    }
}
