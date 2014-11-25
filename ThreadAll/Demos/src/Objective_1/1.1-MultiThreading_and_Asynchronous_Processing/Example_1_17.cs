namespace Demos.src.Objective_1._1._1_MultiThreading_and_Asynchronous_Processing
{
    //1.17 Using Parallel.Break e Parallel.Stop - lowestbreakiteration = 500 no Brek e Null no Stop

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
            ParallelLoopResult result = Parallel.For(0, 1000, (int i, ParallelLoopState loopstate) =>
                {
                    Console.WriteLine("Value For i {0}", i);
                    if (i==500)
                    {
                        Console.WriteLine("Breaking Loop");
                        loopstate.Break();
                    }
                    return;
                });
            Console.WriteLine("State of loopState.IsCompleted {0}", result.IsCompleted);
            Console.WriteLine("State of lowestBreakIteration {0}", result.LowestBreakIteration);
            Console.ReadKey();
        }
    }
}

     */
}
