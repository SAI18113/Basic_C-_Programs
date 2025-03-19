using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSeries
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length of Series: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int x = 0, y = 1;
            Console.Write($"{x} {y} ");
            for(int i =2; i<n; i++)
            {
                int sum = x + y;
                Console.Write($"{sum} ");
                x = y;
                y = sum;
            }
        }
    }
}
