namespace Demos.src.Objective_1._1._1_MultiThreading_and_Asynchronous_Processing
{
//1.11 Scheduling Different continuation tasks

    /*
using System;
using System.Threading.Tasks;

namespace Demos
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Task<int> t = Task.Run(() =>
                {
                    return 42;
                });
            t.ContinueWith((i) =>
                    {
                        Console.WriteLine("Canceled");
                    }, TaskContinuationOptions.OnlyOnCanceled);
            t.ContinueWith((i) =>
                {
                    Console.WriteLine("Faulted");
                }, TaskContinuationOptions.OnlyOnFaulted);
            var compledtedTask = t.ContinueWith((i) =>
                {
                    Console.WriteLine("Completed");
                }, TaskContinuationOptions.OnlyOnRanToCompletion);

            compledtedTask.Wait();
           
            Console.WriteLine(t.Result);
            Console.ReadKey();
        }
    }
}
     
     */
}
