using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    internal class SortedSet1
    {
        static void Main(string[] args)
        {
            SortedSet<int> numbers = new SortedSet<int>();

            numbers.Add(5);
            numbers.Add(3);
            numbers.Add(7);
            numbers.Add(1);

            Console.WriteLine("SortedSet elements:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            int searchNumber = 3;
            if (numbers.Contains(searchNumber))
            {
                Console.WriteLine($"Element {searchNumber} exists in the SortedSet.");
            }
            else
            {
                Console.WriteLine($"Element {searchNumber} does not exist in the SortedSet.");
            }
        }
}
}
