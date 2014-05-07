using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Parallel_1_16
{
    static class Program
    {
        public static void Main(string[] args)
        {
            ParallelLoopResult _result = Parallel.For(0, 1000, (int i, ParallelLoopState _loopState) =>
                {
                    Console.WriteLine(i);
                    if (i == 500)
                    {
                        Console.WriteLine("Breaking Loop");
//                        _loopState.Break(); //waits until the open iterations finish
                        _loopState.Stop(); //terminates everything

                    }
                    Console.ReadKey();
                });
        }
    }
}
