using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if(n <= 1)
            {
                Console.WriteLine($"{n} is not a Prime number");
                return;
            }
            for(int i = 2; i<=n/2; i++)
            {
                if(n%i == 0)
                {
                    Console.WriteLine($"{n} is not a Prime number");
                    return;
                }
            }
            Console.WriteLine($"{n} is a prime number");
        }
    }
}
