namespace Demos.src.Objective_1._1._1_MultiThreading_and_Asynchronous_Processing
{
    //1.19 Scalability versus responsiveness

    /*
    using System;
using System.Threading;
using System.Threading.Tasks;

namespace Demos
{
    public static class Program
    {
        public static Task SleepAsyncA(int millisecondsTimeout)
        {
            return Task.Run(() => Thread.Sleep(millisecondsTimeout));
        }

        public static Task SleepAsyncB(int millisecondsTimeout)
        {
            TaskCompletionSource<bool> tcs = null;
            var t = new Timer(delegate { tcs.TrySetResult(true); }, null, -1, -1);
            tcs = new TaskCompletionSource<bool>(t);
            t.Change(millisecondsTimeout, -1);
            return tcs.Task;
        }

        public static void Main(string[] args)
        {
            SleepAsyncA(500);
            Console.WriteLine("Async A");
            SleepAsyncB(500);
            Console.WriteLine("Async B");
            Console.ReadKey();

            
        }

    }
}

     */

}
