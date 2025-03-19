using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCIINumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Loop through ASCII values of 'a' (97) to 'z' (122)
            for (int i = 97; i <= 122; i++)
            {
                Console.Write((char)i + " "); // Convert ASCII value to character and print
            }

            Console.WriteLine();

            // Loop through ASCII values of 'A' (65) to 'Z' (90)
            for (int i = 65; i <= 90; i++)
            {
                Console.Write((char)i + " "); // Convert ASCII value to character and print
            }
        }
    }
}
