﻿namespace StackAndQueue
{
    class Program
    {
        public static void Main(string[] args)
        {
            //LinkedListStack linkedListStack = new LinkedListStack();
            //linkedListStack.Push(56);
            //linkedListStack.Push(30);
            //linkedListStack.Push(70);

            //linkedListStack.Peek();
            //linkedListStack.Pop();

            //linkedListStack.Display();

            LinkedListQueue linkedListQueue = new LinkedListQueue();
            linkedListQueue.Enqueue(56);
            linkedListQueue.Enqueue(30);
            linkedListQueue.Enqueue(70);

            linkedListQueue.Dequeue();

            linkedListQueue.Display();







        }
    }
}