using System;
using System.Threading;

namespace Part5
{
    class Program
    {


        static void Main(string[] args)
        {
            ThreadLocking obj = new ThreadLocking();

            Thread t1 = new Thread(obj.Display);
            Thread t2 = new Thread(obj.Display);
            Thread t3 = new Thread(obj.Display);

            t1.Start("C#"); t2.Start("Java"); t3.Start("Python");

            Console.ReadKey();
        }
    }
}
