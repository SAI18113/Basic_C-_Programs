using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAPTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 11, b = 13;
            Console.WriteLine(a + " " + b);
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine(a + " " + b);
        }
    }
}
