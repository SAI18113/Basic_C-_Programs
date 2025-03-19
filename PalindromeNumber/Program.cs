using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int orginalNumber = n;
            int reverseNumber = 0;
            while (n > 0)
            {
                int digit = n % 10;
                reverseNumber = reverseNumber * 10 + digit;
                n = n / 10;
            }
            Console.WriteLine($"Reversed Number: {reverseNumber}");

            if(orginalNumber == reverseNumber)
            {
                Console.WriteLine($"{reverseNumber} is Palindrome");
            }

        }
    }
}
