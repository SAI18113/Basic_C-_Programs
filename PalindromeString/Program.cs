using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string word = Console.ReadLine();
            string reversedWord = "";
            for (int i = word.Length - 1; i >= 0; i--)
            {
                reversedWord += word[i];
            }
            Console.WriteLine($"Reversed String: {reversedWord}");
            if (word == reversedWord)
            {
                Console.WriteLine($"{word} is a palndrome string");
            }
            else
            {
                Console.WriteLine($"{word} is not a palndrome string");
            }
        }
    }
}
