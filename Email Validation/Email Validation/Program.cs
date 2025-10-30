using System;
using System.Text.RegularExpressions;

namespace EmailValidaton
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter your email: ");
            string email = Console.ReadLine();

            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            if (Regex.IsMatch(email, pattern))
            {
                Console.WriteLine(" Valid email address!");
            }
            else
            {
                Console.WriteLine(" Invalid email address!");
            }

            Console.ReadLine();
        }
    }
}
