using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Part5
{
    public class ThreadLocking
    {
        public void Display(object languageObj)
        {
            var language = languageObj.ToString();

            lock (this)
            {
                Console.Write($"[{language} is an ");
                Thread.Sleep(3000);
                Console.WriteLine($"object oriented language]");
            }
        }
    }
}
