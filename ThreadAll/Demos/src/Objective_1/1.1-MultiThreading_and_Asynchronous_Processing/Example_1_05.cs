namespace Demos.src.Objective_1._1._1_MultiThreading_and_Asynchronous_Processing
{
    //1.5 - Using The ThreadStaticAttribute

    /*
using System;
using System.Threading;

namespace Demos
{
    public static class Program
    {
        [ThreadStatic]
        public static int _field;

        public static void Main(string[] args)
        {
            new Thread(() =>
                {
                    for (int x=0;x<10;x++)
                    {
                        _field++;
                        Console.WriteLine("Thread A: {0} ", _field);
                    }
                }).Start();

            new Thread(() =>
            {
                for (int x=0;x<10;x++)
                {
                    _field++;
                    Console.WriteLine("Thread B: {0} ", _field);
                }
            }).Start();

            Console.ReadKey();
        }
    }
}

     */
}
