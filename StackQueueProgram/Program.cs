
using System;

namespace StackQueueProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Stack Queue Program");

            Stack stack = new Stack();
            stack.Push(56);
            stack.Push(30);
            stack.Push(70);
            stack.Display();
            stack.Peek();
            stack.Pop();
            Console.WriteLine("Stack after pop operation");
            stack.Display();
        }
    }
}
