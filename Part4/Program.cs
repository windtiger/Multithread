using System;
using System.Threading;

namespace Part4
{
    class Program
    {

        static void Test1()
        {
            Console.WriteLine($"Thread1 is starting.");

            for (int i = 1; i <= 25; i++)
            {
                Console.WriteLine($"Test1:{i}");
            }

            Thread.Sleep(5000);

            Console.WriteLine($"Thread1 is exiting");

        }

        static void Test2()
        {
            Console.WriteLine($"Thread2 is starting.");

            for (int i = 1; i <= 25; i++)
            {
                Console.WriteLine($"Test2:{i}");
            }

            Console.WriteLine($"Thread2 is exiting.");

        }

        static void Test3()
        {
            Console.WriteLine($"Thread3 is starting.");

            for (int i = 1; i <= 25; i++)
            {
                Console.WriteLine($"Test3:{i}");
            }

            Console.WriteLine($"Thread3 is exiting.");

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Main thread started.");

            Thread t1 = new Thread(Test1);
            Thread t2 = new Thread(Test2);
            Thread t3 = new Thread(Test3);

            t1.Start(); t2.Start(); t3.Start();
            t1.Join(3000); t2.Join(); t3.Join();

            Console.WriteLine("Main thread Exited.");

            Console.ReadKey();
        }
    }
}
