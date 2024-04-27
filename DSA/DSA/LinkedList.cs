using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    internal class LinkedList
    {
        public void print(LinkedList<int> list)
        {
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
        }
        public void Menu1()
        {
            LinkedList<int> list = new LinkedList<int>();
            list.AddFirst(1);
            list.AddFirst(2);
            list.AddFirst(3);
            list.AddFirst(4);
            print(list);
            Console.WriteLine("---------------------------------");
            list.AddLast(5);
            list.AddLast(6);
            print(list);
            Console.WriteLine("---------------------------------");
            Console.WriteLine(list.FindLast(5).Value);
            Console.WriteLine("---------------------------------");
            Console.WriteLine(list.Find(2).Value);
            Console.WriteLine("---------------------------------");
            list.RemoveFirst();
            print(list);
            Console.WriteLine("---------------------------------");
            list.RemoveLast();
            print(list);
            Console.WriteLine("---------------------------------");
            list.Remove(5);
            print(list);
            Console.WriteLine("---------------------------------");
            list.Clear();
            print(list);
        }
    }
}
