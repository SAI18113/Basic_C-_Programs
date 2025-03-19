using System;

namespace SingleTonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //No thread safe singleton
            //Call the GetInstance static method to get the Singleton Instance
            Console.WriteLine("------No thread safe singleton------");
            Singleton fromTeacher = Singleton.GetInstance();
            fromTeacher.PrintDetails("From Teacher");

            //Call the GetInstance static method to get the Singleton Instance
            Singleton fromStudent = Singleton.GetInstance();
            fromStudent.PrintDetails("From Student");
            Console.WriteLine("------No thread safe singleton------");

            //Thread safe singleton
            Console.WriteLine("------Thread safe singleton------");
            ThreadSingleton ts1 = ThreadSingleton.Instance;
            ts1.PrintDetails("Called from ts1");

            ThreadSingleton ts2 = ThreadSingleton.Instance;
            ts1.PrintDetails("Called from ts2");
            Console.WriteLine("------Thread safe singleton------");

            //Thread safe singleton using lock
            Console.WriteLine("------Thread safe singleton using lock------");
            ThreadLockSingleton tls1 = ThreadLockSingleton.Instance;
            tls1.PrintDetails("Called from tls1");

            ThreadLockSingleton tls2 = ThreadLockSingleton.Instance;
            tls2.PrintDetails("Called from tls2");
            Console.WriteLine("------Thread safe singleton using lock------");
            /*As you can see in the above output, it clearly shows that private constructor is executed only once, even though we have called the 
            GetInstance method twice and printed the counter value as 1.*/
        }
    }
}

