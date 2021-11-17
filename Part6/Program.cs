using System;
using System.Threading;

namespace Part6
{
    class Program
    {

        public static void IncrementCounter1()
        {
            for (int i = 1; i < 100; i++)
            {
                Console.WriteLine($"IncrementCounter1 : {i}");
            }
        }

        public static void IncrementCounter2()
        {
            for (int i = 1; i < 100; i++)
            {
                Console.WriteLine($"IncrementCounter2 : {i}");
            }
        }

        static void Main(string[] args)
        {
            var t1 = new Thread(IncrementCounter1);
            var t2 = new Thread(IncrementCounter2);

            t1.Priority = ThreadPriority.Highest;

            t1.Start();
            t2.Start();
            Thread.Sleep(1000);

            Console.ReadKey();
        }
    }
}
