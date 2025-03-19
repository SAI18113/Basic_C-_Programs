using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //The Client will use the Facade Interface instead of the Subsystems
            Order order = new Order();
            order.PlaceOrder();
            Console.Read();
        }
    }
}
