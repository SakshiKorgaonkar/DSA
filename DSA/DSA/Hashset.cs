using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    internal class Hashset1
    {
        public void Menu()
        {
            HashSet<int> keys = new HashSet<int>();
            keys.Add(0);
            keys.Add(1);
            keys.Add(2);
            keys.Add(3);
            keys.Add(4);

            keys.Add(3);
            Console.WriteLine("Hashset elements : ");
            foreach (int key in keys)
            {
                Console.WriteLine(key);
            }

            int search = 44;
            if(keys.Contains(search))
            {
                Console.WriteLine("Element present");
            }
            else
            {
                Console.WriteLine("element not found");
            }
            keys.Remove(2);
            Console.WriteLine("Elements after removing : ");
            foreach (var item in keys)
            {
                Console.WriteLine(item);
            }
            keys.Clear();
            Console.WriteLine("hashset after clearing : ");
            Console.WriteLine(keys.Count);
        }
    }
}
