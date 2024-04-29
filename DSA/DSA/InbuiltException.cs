using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    internal class InbuiltException
    {
        static void Division(int num,int den)
        {
            try
            {
                int result=num / den;
            }
            catch(ArithmeticException e)
            {
                Console.WriteLine("Exception occured : "+e.ToString());
                try
                {
                    int[] ints = new int[2];
                    ints[3] = 5;
                }
                catch (IndexOutOfRangeException e1)
                {
                    Console.WriteLine("Second exception occured : " + e1.ToString());
                }
            }
            finally
            {
                Console.WriteLine("Finally block");
            }
        }
        public void Menu()
        {
            Division(3, 0);
        }
    }
}
