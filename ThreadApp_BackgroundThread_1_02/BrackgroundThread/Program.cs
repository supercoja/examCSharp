using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace BrackgroundThread
{
    public static class Program
    {
        public static void ThreadMethod()
        {
            for (int i=0;i<10;i++)
            {
                Console.WriteLine("ThreadProc: {0} ", i);
                Thread.Sleep(1000);
            }
        }

        public static void Main(string[] args)
        {
            Thread _t = new Thread(new ThreadStart(ThreadMethod));
            _t.IsBackground = true;
//            _t.IsBackground = false;
            _t.Start();
//            Console.WriteLine("End of The Thread");
  //          Console.ReadLine();
        }
    }
}
