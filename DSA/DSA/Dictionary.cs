using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    internal class Dictionary1
    {
        public void Menu()
        {
            Dictionary<int, string> myDictionary = new Dictionary<int, string>();

            myDictionary.Add(1, "sakshi");
            myDictionary.Add(2, "renuka");
            myDictionary.Add(3, "saloni");

            Console.WriteLine(myDictionary[1]); 

            if (myDictionary.ContainsKey(2))
            {
                myDictionary.Remove(2);
            }

            foreach (var pair in myDictionary)
            {
                Console.WriteLine($"Key: {pair.Key}, Value: {pair.Value}");
            }
        }
    }
}
