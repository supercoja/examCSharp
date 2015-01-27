namespace Demos.src.Objective_1._1._3_Implement_program_Flow
{
//1.31 - Enumerating a ConcurrentBag
    /*
using System;
using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;

namespace Demos
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ConcurrentBag<int> bag = new ConcurrentBag<int>();
            Task.Run(() =>
                {
                    bag.Add(42);
                    Thread.Sleep(1000);
                    bag.Add(21);
                });
            Task.Run(() =>
                {
                    foreach (int i in bag)
                    {
                        Console.WriteLine(i);
                    }
                }).Wait();

            Console.ReadKey();
        }
    }
}


     */
}
