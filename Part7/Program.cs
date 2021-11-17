using System;
using System.Diagnostics;
using System.Threading;

namespace Part7
{
    class Program
    {
        static void Main(string[] args)
        {
            SingleThread();
            MultiThread();

            Console.ReadKey();
        }

        private static void SingleThread()
        {
            Console.WriteLine($"SingleThread----------");

            var sw = new Stopwatch();

            sw.Start();
            ThreadPerformance.IncrementCounter1();
            ThreadPerformance.IncrementCounter2();
            sw.Stop();

            Console.WriteLine($"{sw.Elapsed.TotalSeconds} sec");
        }

        private static void MultiThread()
        {
            Console.WriteLine($"MultiThread----------");

            var sw = new Stopwatch();

            var t1 = new Thread(ThreadPerformance.IncrementCounter1);
            var t2 = new Thread(ThreadPerformance.IncrementCounter2);

            sw.Start();

            t1.Start();
            t2.Start();

            t1.Join();
            t2.Join();

            sw.Stop();

            Console.WriteLine($"{sw.Elapsed.TotalSeconds} sec");
        }


    }
}
