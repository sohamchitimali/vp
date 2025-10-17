using System;
using MathLibrary;

namespace PrivateAssemblyDemo
{
    class Program
    {
        static void Main()
        {
            Calculator calc = new Calculator();
            int result = calc.Add(10, 20);
            Console.WriteLine("Result from private assembly: " + result);
            Console.ReadLine();
        }
    }
}