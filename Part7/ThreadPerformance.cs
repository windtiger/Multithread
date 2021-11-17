using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part7
{
    public class ThreadPerformance
    {
        public static void IncrementCounter1()
        {
            
            long count = 0;
            for (long i = 0; i <= int.MaxValue; i++)
            {
                count++;
            }

            Console.WriteLine($"IncrementCounter1:{count}");
        }

        public static void IncrementCounter2()
        {
            long count = 0;
            for (long i = 0; i <= int.MaxValue; i++)
            {
                count++;
            }

            Console.WriteLine($"IncrementCounter1:{count}");
        }
    }
}
