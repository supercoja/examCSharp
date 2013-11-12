using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ThreadApp_01
{
    public static class Program
    {

        public static void ThreadMethod()
        {
            for (int i=0;i<10;i++)
            {
                Console.WriteLine("ThreadProc {0}", i);
                Thread.Sleep(0);
            }
        }

        public static void Main(string[] args)
        {
            Thread _t = new Thread(new ThreadStart(ThreadMethod));
            _t.Start();

            for (int i=0;i<4;i++)
            {
                Console.WriteLine("Main Thread: Do Some Work;");
                Thread.Sleep(0);
            }

            _t.Join();
            int x = 0;
        }
    }
}
