using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleTonPattern
{
    //Thread safe singleton class using lock
    public sealed class ThreadLockSingleton
    {
        // This variable value will be incremented by 1 each time the object of the class is created
        public static int Counter = 0;

        // Using explicit locks for thread safety
        private static ThreadLockSingleton _instance;
        private static readonly object _lock = new object();

        // Public method to get the Singleton instance
        public static ThreadLockSingleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new ThreadLockSingleton();
                        }
                    }
                }
                return _instance;
            }
        }

        // Private constructor to prevent instance creation outside the class
        private ThreadLockSingleton()
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
