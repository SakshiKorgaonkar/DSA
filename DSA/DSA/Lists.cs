using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    internal class Lists
    {
        void print(List<string> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
        public void Menu()
        {
            List<string> list = new List<string>()
            {
                 "sakshi","renuka","vikrant","rohit","prasad" 
            };
            string[] arr = new string[10];
            Lists lists = new Lists();  
            lists.print(list);
            Console.WriteLine("--------------------");
            list.Add("saloni");
            lists.print(list);
            Console.WriteLine("--------------------");
            list.Sort();
            lists.print(list);
            Console.WriteLine("--------------------");
            Console.WriteLine(list.Capacity);
            Console.WriteLine("--------------------");
            Console.WriteLine(list.Contains("sara"));
            Console.WriteLine("--------------------");
            list.CopyTo(arr,2);
            foreach (var item in arr)
            {
                Console.WriteLine($"{item}");
            }


        }
    }
}
