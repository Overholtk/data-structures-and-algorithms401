using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedLists
{
    public class PseudoQueue<T>
    {
        public Stack<T> stack1 = new Stack<T>();
        public Stack<T> stack2 = new Stack<T>();
        //not sure why I can't push any values into the stacks here, but I'm getting a "stack1 does not exist in current context whenever I try to use it in main
        

        /// <summary>
        /// pushes the value from param onto the stack
        /// </summary>
        /// <param name="value">an</param>
        /// <returns></returns>
        public T enqueue(T value)
        {
            stack1.Push(value);
            return stack1.top.Value;
        }

        /// <summary>
        /// iterates through the stack, reversing it's order, then saves the node now at the top of that stack, and reverses it back to it's normal order
        /// </summary>
        /// <returns>returns node that has been removed from the stack</returns>
        public Node<T> dequeue()
        {
            Node<T> current1 = stack1.top;
            while(current1 != null)
            {
                Node<T> hold = stack1.pop();
                stack2.Push(hold.Value);
                current1 = stack1.top;
            }
            return stack2.top;
        }
    }
}
