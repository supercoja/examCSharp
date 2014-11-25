
namespace Demos.src.Objective_1._1._1_MultiThreading_and_Asynchronous_Processing
{
    //1.6 - Using ThreadLocal<T>
 /*
    using System;
    using System.Threading;

    namespace Demos
    {
        public static class Program
        {
            public static ThreadLocal<int> _field =
                new ThreadLocal<int>(() =>
                    {
                        return Thread.CurrentThread.ManagedThreadId;
                    });

            public static void Main(string[] args)
            {
                Console.WriteLine("Inicialization of Field {0}", _field.Value);
                new Thread(() =>
                    {
                        for (int x=0;x<_field.Value;x++)
                        {
                            Console.WriteLine("Thread A: {0} ", x);
                        }
                    }).Start();

                new Thread(() =>
                {
                    for (int x=0;x<_field.Value;x++)
                    {
                        Console.WriteLine("Thread B: {0} ", x);
                    }
                }).Start();

                Console.ReadKey();
            }
        }
    }
*/
}
