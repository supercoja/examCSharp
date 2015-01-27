namespace Demos.src.Objective_1._1._2_Manage_Multithreading
{
    class Example_1_37
    {
        /* 1 - 37 Creating a Deadlock
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Demos
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var lockA = new object();
            var lockB = new object();

            var up = Task.Run(() =>
                {
                    lock (lockA)
                    {
                        Thread.Sleep(1000);
                        lock (lockB)
                        {
                            Console.WriteLine("Locked A and B");
                        }
                    }
                });
            lock (lockB)
            {
                lock (lockA)
                {
                    Console.WriteLine("Locked A and B");
                }
            }
            up.Wait();
        }
    }
}
          
         */
    }
}
