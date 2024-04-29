using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    internal class HashTable1
    {
        static void Main()
        {
            Hashtable hashtable = new Hashtable();

            hashtable.Add("one", 1);
            hashtable.Add("two", 2);
            hashtable.Add("three", 3);

            Console.WriteLine($"Value for key 'two': {hashtable["two"]}");

            if (hashtable.ContainsKey("four"))
            {
                Console.WriteLine("Key 'four' exists in the Hashtable.");
            }
            else
            {
                Console.WriteLine("Key 'four' does not exist in the Hashtable.");
            }
            foreach (DictionaryEntry entry in hashtable)
            {
                Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
            }
        }
    }

}

