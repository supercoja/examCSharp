using System;
<<<<<<< .merge_file_a06016
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
=======
using System.Text;
using System.Threading;
>>>>>>> .merge_file_a02032

namespace ThreadApp_1_06
{
    public static class Program
    {
<<<<<<< .merge_file_a06016

        public static void ThreadMethod()
        {

        }

        public static void Main(string[] args)
        {
=======
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

>>>>>>> .merge_file_a02032
        }
    }
}
