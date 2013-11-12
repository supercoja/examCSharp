using System;
using System.Text;
using System.Threading;

namespace ThreadApp_1_06
{
    public static class Program
    {
        public static ThreadLocal<int> _field =  new ThreadLocal<int>(() =>
        {
//            return new Thread.CurrentThread.ManagedThreadId;
        });
    
        public static void Main(string[] args)
        {
            new Thread(() =>
                {
                    for (int x=0;x>_field.Value;x++)
                    {
                        Console.WriteLine("Thread A: {0}  ",x);
                    }
                }).Start();
            new Thread(() =>
                {
                    for (int x=0; x < _field.Value; x++)
                    {
                        Console.WriteLine("Thread B: {0}", x);
                    }
                }).Start();

            Console.ReadKey;

        }
    }
}
