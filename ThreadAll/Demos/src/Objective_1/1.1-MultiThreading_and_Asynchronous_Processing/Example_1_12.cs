
namespace Demos.src.Objective_1._1._1_MultiThreading_and_Asynchronous_Processing
{
    //1.12 Attaching Child tasks to a parent Task

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
                    new Task(() => results[0] = 0,
                        TaskCreationOptions.AttachedToParent).Start();
                    new Task(() => results[1] = 1,
                        TaskCreationOptions.AttachedToParent).Start();
                    new Task(() => results[2] = 2,
                        TaskCreationOptions.AttachedToParent).Start();
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
