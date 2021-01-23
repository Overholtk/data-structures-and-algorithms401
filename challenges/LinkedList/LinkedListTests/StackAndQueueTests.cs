using System;
using Xunit;
using System.Text;
using LinkedLists;

namespace LinkedListTests
{
    public class StackAndQueueTests
    {
        [Fact]
        public void Push_To_Stack()
        {
            Stack<string> test = new Stack<string>();
            test.Push("15");
            Assert.Equal("15", test.top);

        }
    }
}
