namespace Demos.src.Objective_1._1._2_Manage_Multithreading
{
    class Example_1_36
    {
        /* 1 - 36 Using The Lock Keyword
using System;
using System.Threading.Tasks;

namespace Demos
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = 0;
            var _lock = new object();
            var up = Task.Run(() =>
                {
                    for (int i = 0; i < 10000000; i++)
                       lock (_lock)
                        n++;
                });
            for (int i = 0; i < 10000000; i++)
            {
                lock (_lock)
                n--;
            }
            up.Wait();
            Console.WriteLine(n);
        }
    }
}
         
         */
    }
}
