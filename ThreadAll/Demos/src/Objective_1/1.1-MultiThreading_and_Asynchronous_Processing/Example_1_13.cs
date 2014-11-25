namespace Demos.src.Objective_1._1._1_MultiThreading_and_Asynchronous_Processing
{
    //1.13 Using a TaskFactory

    /*
using System;
using System.Threading.Tasks;

namespace Demos
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Task<Int32[]> parentTask = Task.Run(() =>
                {
                    var results = new Int32[3];

                    TaskFactory taskFactory = new
                        TaskFactory(TaskCreationOptions.AttachedToParent,
                        TaskContinuationOptions.ExecuteSynchronously);
                    taskFactory.StartNew(() => results[0] = 0);
                    taskFactory.StartNew(() => results[1] = 1);
                    taskFactory.StartNew(() => results[2] = 2);
                    return results;
                });

            var finalTask = parentTask.ContinueWith(
                childTask =>
                {
                    foreach (int resultIndex in childTask.Result)
                    {
                        Console.WriteLine(resultIndex);
                    }
                });

            finalTask.Wait();
            Console.ReadKey();           
        }
    }
}
 
     */
}
