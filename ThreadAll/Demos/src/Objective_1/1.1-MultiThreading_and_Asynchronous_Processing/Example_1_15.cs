namespace Demos.src.Objective_1._1._1_MultiThreading_and_Asynchronous_Processing
{
// 1.15 Using Task.WaitAny

    /*
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Demos
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Task<int>[] taskCollection = new Task<int>[3];

            taskCollection[0] = Task.Run(() => { Thread.Sleep(2000); return 1;});
            taskCollection[1] = Task.Run(() => { Thread.Sleep(1000); return 2;});
            taskCollection[2] = Task.Run(() => { Thread.Sleep(3000); return 3;});

            while (taskCollection.Length > 0)
            {
                int i = Task.WaitAny(taskCollection);
                Task<int> completedTask = taskCollection[i];

                Console.WriteLine(completedTask.Result);

                var temp = taskCollection.ToList();
                temp.RemoveAt(i);
                taskCollection = temp.ToArray();
            }
        }
    }
}

     */
}
