using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DSA
{
    internal class Regex1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter phone number : ");
            string number=Console.ReadLine();
            Console.WriteLine("Enter email address : ");
            string email=Console.ReadLine();
            Console.WriteLine("Enter password : ");
            string password=Console.ReadLine();

            if (IsValidPhoneNumber(number))
            {
                Console.WriteLine("Phone number is valid.");
            }
            else
            {
                Console.WriteLine("Phone number is not valid.");
            }
            if (IsValidEmail(email))
            {
                Console.WriteLine("Email is valid.");
            }
            else
            {
                Console.WriteLine("Email is not valid.");
            }
            if (IsValidPassword(password))
            {
                Console.WriteLine("Password is valid.");
            }
            else
            {
                Console.WriteLine("Password is not valid.");
            }
        }
        static bool IsValidPhoneNumber(string phoneNumber)
        {
            string pattern = @"^\d{10}$";
            return Regex.IsMatch(phoneNumber, pattern);
        }
        static bool IsValidEmail(string email)
        {
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, emailPattern);
        }
        static bool IsValidPassword(string password)
        {
            string passwordPattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$";
            return Regex.IsMatch (password, passwordPattern);
        }
    }
}
