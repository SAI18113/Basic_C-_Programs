using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuplicatesInAString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "example";
            int[] charCount = new int[input.Length]; // Array to count occurrences

            // Initializing charCount array
            for (int i = 0; i < input.Length; i++)
            {
                charCount[i] = 0;
            }

            // Counting occurrences of each character
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < input.Length; j++)
                {
                    if (input[i] == input[j])
                    {
                        charCount[i]++;
                    }
                }
            }

            // Printing duplicate characters
            Console.Write("Duplicate characters: ");
            for (int i = 0; i < input.Length; i++)
            {
                if (charCount[i] > 1)
                {
                    Console.WriteLine(input[i]);
                    for (int j = 0; j < input.Length; j++)
                    {
                        if (input[i] == input[j])
                        {
                            charCount[j] = 0; // Avoid printing duplicates multiple times
                        }
                    }
                }
            }
        }
    }
}
