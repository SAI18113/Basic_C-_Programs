using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverLoading
{
    class Program
    {
        public class Calculator
        {
            // Method overloading: multiple methods with the same name but different parameters.

            // Method to add two integers
            public int Add(int a, int b)
            {
                return a + b;
            }

            // Method to add three integers
            public int Add(int a, int b, int c)
            {
                return a + b + c;
            }

            // Method to add two doubles
            public double Add(double a, double b)
            {
                return a + b;
            }

            // Method to add an integer and a double
            public double Add(int a, double b)
            {
                return a + b;
            }

            //Method to add a double and an int.
            public double Add(double a, int b)
            {
                return a + b;
            }

            //Method to add two strings.
            public string Add(string a, string b)
            {
                return a + b;
            }
        }
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            Console.WriteLine($"Adding two integers: {calculator.Add(5, 10)}");
            Console.WriteLine($"Adding three integers: {calculator.Add(5, 10, 15)}");
            Console.WriteLine($"Adding two doubles: {calculator.Add(3.5, 2.7)}");
            Console.WriteLine($"Adding an integer and a double: {calculator.Add(5, 3.2)}");
            Console.WriteLine($"Adding a double and an integer: {calculator.Add(2.2, 5)}");
            Console.WriteLine($"Adding two strings: {calculator.Add("Hello, ", "World!")}");
        }
    }
}
