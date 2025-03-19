using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfDigitsInaString
{
    class Program
    {
        static void Main(string[] args)
        {
            //string input = "a1b2c3";
            //int sum = input.Where(char.IsDigit) // Filter only digits
            //               .Select(c => c - '0') // Convert char to int
            //               .Sum(); // Sum them up

            //Console.WriteLine($"Sum of digits: {sum}");

            Console.WriteLine("Enter a string: ");
            string value = Console.ReadLine();
            int sum = 0;

            for (int i = 0; i < value.Length; i++)
            {
                if (char.IsDigit(value[i]))
                {
                    sum += value[i] - '0';
                }
            }

            Console.WriteLine($"The sum of digits in a string is {sum}");
        }
    }
}
