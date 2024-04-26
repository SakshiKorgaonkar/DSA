using System;
using System.Collections.Immutable;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace DataStructure
{
    class Node
    {
        int data { get; set; }
        Node next { get; set; }

        Node(int data)
        {
            this.data = data;
            this.next = null;
        }
        internal class Stack
        {
            Node top;
            Stack()
            {
                top = null;
            }
            public Boolean isEmpty()
            {
                return top == null;
            }
            public void push(int data)
            {
                Node node = new Node(data);
                if (isEmpty())
                {
                    top = node;
                }
                else
                {
                    node.next = top;
                    top=node;
                }
            }
            public int pop()
            {
                if (isEmpty())
                {
                    return -1;
                }
                int element = top.data;
                top = top.next;
                return element;
            }
            public int peek()
            {
                if (isEmpty())
                {
                    return -1;
                }
                return top.data;
            }
            public void printstack()
            {
                if (isEmpty())
                {
                    Console.WriteLine("Stack is empty");
                }
                Node current = top;
                while (current != null)
                {
                    Console.WriteLine(current.data);
                    current = current.next;
                }
            }
            static void Main(string[] args)
            {
                Stack stack = new Stack();
                stack.push(1);
                Console.WriteLine("Pushed 1 ");
                stack.push(2);
                Console.WriteLine("Pushed 2");
                stack.push(3);
                Console.WriteLine("Pushed 3");
                stack.push(4);
                Console.WriteLine("Pushed 4");
                Console.WriteLine("Stack elements : ");
                stack.printstack();
                Console.WriteLine("Removed element : ");
                Console.WriteLine(stack.pop());
                Console.WriteLine("Stack elements : ");
                stack.printstack();
                Console.WriteLine("Topmost element : ");
                Console.WriteLine(stack.peek());
                Console.WriteLine("Stack elements : ");
                stack.printstack();
                Console.WriteLine("Removed element : ");
                Console.WriteLine(stack.pop());
                Console.WriteLine("Stack elements : ");
                stack.printstack();
            }
        }
    }
}

