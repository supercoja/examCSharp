namespace Demos.src.Objective_1._1._1_MultiThreading_and_Asynchronous_Processing
{
    // 1.4 Stopping a Thread
    /*
    using System;
    using System.Threading;

    namespace Demos
    {
        public static class Program
        {
            public static void ThreadMethod(object o)
            {
                for (int i = 0; i < (int)o; i++)
                {
                    Console.WriteLine("ThreadProc: {0}", i);
                    Thread.Sleep(0);
                }
            }

            public static void Main(string[] args)
            {
                bool isStopped = false;
                Thread t = new Thread(new ThreadStart(() =>
                {
                    while (!isStopped)
                    {
                        Console.WriteLine("Running...");
                        Thread.Sleep(1000);
                    }
                }));

                t.Start();
                Console.WriteLine("Press Any Key to Exit");
                Console.ReadKey();
                isStopped = true;
                t.Join();
            }
        }
    }

     */
}
