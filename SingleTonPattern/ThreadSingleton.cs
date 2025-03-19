using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleTonPattern
{
    //Thread safe singleton class.
    public sealed class ThreadSingleton
    {
        // This variable value will be incremented by 1 each time the object of the class is created
        public static int Counter = 0;

        // Using Lazy<T> to ensure thread safety and lazy initialization
        private static readonly Lazy<ThreadSingleton> _instance =
            new Lazy<ThreadSingleton>(() => new ThreadSingleton());

        // Public property to get the Singleton instance
        public static ThreadSingleton Instance => _instance.Value;

        // Private constructor to prevent instance creation outside the class
        private ThreadSingleton()
        {
            Counter++;
            Console.WriteLine($"Counter value {Counter}");
        }

        // The following can be accessed from outside of the class by using the Singleton Instance
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}
