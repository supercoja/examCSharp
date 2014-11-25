namespace Demos.src.Objective_1._1._1_MultiThreading_and_Asynchronous_Processing
{
    // 1.14 Using Task.WaitAll

    /*
     using System;
using System.Threading;
using System.Threading.Tasks;

namespace Demos
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Task[] taskCollection = new Task[3];

            taskCollection[0] = Task.Run(() =>
                {
                    Thread.Sleep(1000);
                    Console.WriteLine("1");
                    return 1;
                });
            taskCollection[1] = Task.Run(() =>
            {
                Thread.Sleep(2000);
                Console.WriteLine("2");
                return 2;
            });
            taskCollection[2] = Task.Run(() =>
            {
                Thread.Sleep(3000);
                Console.WriteLine("3");
                return 3;
            });

            Task.WaitAll(taskCollection);
               
        }
    }
}

     */
}
