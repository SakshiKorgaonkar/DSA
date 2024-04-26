using System;
using System.Collections.Immutable;
using System.Globalization;
using System.Linq;

namespace DataStructure
{ 
    internal class Array1
    {
        static void Main(string[] args)
        {
            int[] number = new int[] { 11, 4, 90, 16, 25 };

            Console.WriteLine("Original array:");
            foreach (int i in number)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Minimun element "+number.Min());
            Console.WriteLine("Maximum element "+number.Max());
            Console.WriteLine("Length "+ number.Length);
            Console.WriteLine("Rank "+number.Rank);

            Array.Reverse(number);
            Console.WriteLine("Reversed array:");
            foreach (int j in number)
            {
                Console.WriteLine(j);
            }

            Array.Sort(number);
            Console.WriteLine("Sorted array:");
            foreach (int j in number)
            {
                Console.WriteLine(j);
            }
            Console.WriteLine(Array.IndexOf(number, 4));
            Array.Clear(number);
            Console.WriteLine("Cleared array:");
            foreach (int j in number)
            {
                Console.WriteLine(j);
            }
        }
    }
}
