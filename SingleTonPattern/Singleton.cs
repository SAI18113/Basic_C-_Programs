using System;

namespace SingleTonPattern
{
    //No thread safe singleton class.
    public sealed class Singleton
    {
        //This variable value will be increment by 1 each time the object of the class is created
        public static int Counter = 0;

        //This variable is going to store the Singleton Instance
        private static Singleton Instance = null;

        //The following Static Method is going to return the Singleton Instance
        public static Singleton GetInstance()
        {
            //If the variable instance is null, then create the Singleton instance 
            //else return the already created singleton instance
            //This version is not thread safe
            if (Instance == null)
            {
                Instance = new Singleton();
            }

            return Instance;
        }

        //Constructor is Private means, from outside the class we cannot create an instance of this class
        private Singleton()
        {
            Counter++;
            Console.WriteLine($"Counter value {Counter}");
        }

        //The following can be accesed from outside of the class by using the Singleton Instance
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}
