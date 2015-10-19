using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Day6
{
    class StackAndQueue
    {
        public static void executeStackOperations()
        {
            Console.WriteLine("Stack");
            MyStack stack = new MyStack();
            stack.push(10);
            stack.push(60);
            stack.push(80);
            stack.print();
            Console.WriteLine("\npop");
            Console.WriteLine(stack.pop());
            Console.WriteLine(stack.pop());
        }
        public static void executeQueueOperations()
        {
            Console.WriteLine("Queue");
            MyQueue queue = new MyQueue();
            queue.Enqueue(10);
            queue.Enqueue(46);
            queue.Enqueue(546);
            queue.print();
            Console.WriteLine("\nDeque");
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());

        }
    }
    class MyStack
    {
        object[] items;
        int top;
        public MyStack()
        {
            items = new object[10];
            top = -1;
        }
        public int push(object element)
        {
            if (top == items.Length - 1)
                return -1;
            else
            {
                items[++top] = element;
                return top;
            }
        }
        public object pop()
        {
            if (top == -1)
            {
                return null;
            }
            else
            {
                return items[top--];
            }
        }
        public void print()
        {
            for(int i=top;i>=0;i--)
                Console.WriteLine(items[i]);
        }
    }
    class MyQueue
    {
        object[] items;
        int front;
        int rear;
        public MyQueue()
        {
            items = new object[10];
            front = -1;
            rear = -1;
        }
        public bool isEmpty()
        {
            if (front == -1 && rear == -1)
                return true;
            else
                return false;
        }
        public int Enqueue(object element)
        {
            if (rear == items.Length - 1)
                return -1;
            else if (isEmpty())
            {
                front = 0;
                rear = 0;
            }
            else
            {
                rear++;
            }
            items[rear] = element;
            return rear;
        }
        public object Dequeue()
        {
            if (isEmpty()|| front>rear)
            {
                return -1;
            }
            else
                return items[front++];
        }
        public void print()
        {
            for(int i=front;i<=rear;i++)
                Console.WriteLine(items[i]);
        }
    }

}
