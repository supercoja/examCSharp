namespace Demos.src.Objective_1._1._1_MultiThreading_and_Asynchronous_Processing
{
    //1.3 Using The Parameterized Thread Start
    /*
    using System;
    using System.Threading;

    namespace Demos
    {
        public static class Program
        {
            public static void ThreadMethod(object o)
            {
                for (int i=0;i<(int)o;i++)
                {
                    Console.WriteLine("ThreadProc: {0}", i);
                    Thread.Sleep(0);
                }
            }

            public static void Main(string[] args)
            {
                Thread t = new Thread(new ParameterizedThreadStart(ThreadMethod));
                t.Start(5);
                t.Join();
                Console.ReadKey();
            }
        }
    }

     */

}
