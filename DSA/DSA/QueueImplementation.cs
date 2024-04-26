using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    internal class QueueImplementation
    {
        public void Menu()
        {
              Queue<int> queue = new Queue<int>();

                queue.Enqueue(10);
                queue.Enqueue(20);
                queue.Enqueue(30);
                queue.Enqueue(40);
                queue.Enqueue(50);

                Console.WriteLine("Original queue:");
                PrintQueue(queue);

                int removedElement = queue.Dequeue();
                Console.WriteLine($"\nDequeued element: {removedElement}");

                Console.WriteLine("\nQueue after dequeuing:");
                PrintQueue(queue);

                int frontElement = queue.Peek();
                Console.WriteLine($"\nFront element of the queue: {frontElement}");

                bool contains = queue.Contains(30);
                Console.WriteLine($"\nQueue contains element 30: {contains}");
            }

            static void PrintQueue(Queue<int> queue)
            {
                foreach (int num in queue)
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine();
            }
        }
    }
    

