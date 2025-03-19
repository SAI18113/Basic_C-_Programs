using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveDuplicatesInAString
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = "programming", result = "";

            for (int i = 0; i < value.Length; i++)
            {
                if (!result.Contains(value[i]))
                {
                    result += value[i];
                }
            }

            Console.WriteLine($"Result: {result}");

        }
    }
}
