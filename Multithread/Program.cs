using System;
using System.Threading;
using System.Threading.Tasks;

namespace Multithread
{
    class Program
    {
        static void Test1()
        {
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine($"Test1:{i}");
            }

            Console.WriteLine($"Thread1 is exiting");
        }

        static void Test2()
        {
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine($"Test2:{i}");
                if (i == 50)
                {
                    Console.WriteLine($"Thread2 going to sleep.");
                    Thread.Sleep(5000);
                    Console.WriteLine($"Thread2 woke up.");
                }
            }

            Console.WriteLine($"Thread2 is exiting");
        }

        static void Test3()
        {
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine($"Test3:{i}");
            }

            Console.WriteLine($"Thread3 is exiting");
        }


        static void Main(string[] args)
        {

            var T1 = new Task(Test1);
            var T2 = new Task(Test2);
            var T3 = new Task(Test3);

            T1.Start();
            T2.Start();
            T3.Start();

            Console.WriteLine($"Main thread is exiting");
            Console.ReadKey();
        }
    }
}
