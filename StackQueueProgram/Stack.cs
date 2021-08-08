using System;
using System.Collections.Generic;
using System.Text;

namespace StackQueueProgram
{
    class Stack
    {
        private Node top;
        public Stack()
        {
            this.top = null;
        }
        /// <summary>
        /// add value to stack
        /// </summary>
        /// <param name="value"></param>
        public void Push(int value)
        {
            Node node = new Node(value);
            if (this.top == null)
            {
                node.next = null;
            }
            else
            {
                node.next = this.top;
            }
            this.top = node;
            Console.WriteLine("{0} pushed to stack", value);
        }
        /// <summary>
        /// display stack
        /// </summary>
        public void Display()
        {
            Node temp = this.top;
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
    }
}
