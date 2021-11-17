using System;
using System.Threading;

namespace Part3
{
    class Program
    {
        static void Test1()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine($"Test1:{i}");
            }

            Console.WriteLine($"Thread1 is exiting");
        }

        static void Test2(object maxObj)
        {
            int max = Convert.ToInt32(maxObj);
            for (int i = 1; i <= max; i++)
            {
                Console.WriteLine($"Test2:{i}");
            }

            Console.WriteLine($"Thread2 is exiting");
        }

        static void Main(string[] args)
        {
            //ThreadStart obj = new ThreadStart(Test1);
            //ThreadStart obj = Test1;
            //ThreadStart obj = delegate () { Test1(); };
            //ThreadStart obj = () => Test1();
            //Thread t = new Thread(obj);
            //Thread t = new Thread(Test1);
            //t.Start();

            Thread t1 = new Thread(Test2);
            t1.Start(50);

            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
