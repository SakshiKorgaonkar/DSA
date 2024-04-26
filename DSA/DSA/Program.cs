using System;
using System.Collections.Immutable;
using System.Globalization;
using System.Linq;

namespace DataStructure
{
    internal class Array
    {
        static void Main(string[] args)
        {
            int[] squares = new int[] { 1, 4, 9, 16, 25 };

            Console.WriteLine("Original array:");
            foreach (int i in squares)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Minimun element "+squares.Min());
            Console.WriteLine("Maximum element "+squares.Max());
            Console.WriteLine("Length "+ squares.Length);
            Console.WriteLine("Rank "+squares.Rank);

            squares = squares.Reverse().ToArray();

            Console.WriteLine("Reversed array:");
            foreach (int j in squares)
            {
                Console.WriteLine(j);
            }

            int[] numbers1 = { 4, 2, 7, 1, 9 };
            int numberToFind = 7;
            int foundNumber = numbers1.FirstOrDefault(n => n == numberToFind);

            if (foundNumber != 0)
            {
                Console.WriteLine($"Found number: {foundNumber}");
            }
            else
            {
                Console.WriteLine("Number not found");
            }
        }
    }
}
