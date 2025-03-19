using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            while (n > 0)
            {
                int digit = n % 10;
                sum = sum + digit;
                n = n / 10;
            }

            Console.WriteLine($"The sume of the digits is:{sum}");
        }
    }
}
