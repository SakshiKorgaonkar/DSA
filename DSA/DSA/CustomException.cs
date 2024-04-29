using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    class DivisionByZero :Exception
    {
        public DivisionByZero()
        {
            Console.WriteLine("Division by zero exception occured");
        }
    }
    internal class CustomException
    {
        static void Division(int num,int den)
        {
            if(den==0)
                throw new DivisionByZero();
            else
            {
                int result = num / den;
            }
        }
        static void Main2(string[] args)
        {
            try
            {
                Division(3, 0);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception occured : {ex.ToString()}");
            }
        }
    }
}
