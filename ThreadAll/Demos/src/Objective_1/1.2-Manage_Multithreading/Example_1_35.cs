namespace Demos.src.Objective_1._1._2_Manage_Multithreading
{
    class Example_1_35
    {
        /* 1-35 Acessing Shared data in a multithreaded application
using System;
using System.Threading.Tasks;

namespace Demos
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = 0;
            var up = Task.Run(() =>
                {
                    for (int i = 0; i < 10000000; i++)
                        n++;
                });
            for (int i = 0; i < 10000000; i++)
            {
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
