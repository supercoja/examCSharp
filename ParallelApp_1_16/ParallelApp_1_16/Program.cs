using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ParallelApp_1_16
{
    static class Program
    {
        public static void Main(string[] args)
        {
            Parallel .For(0,10,i => 
                {
                    Thread.Sleep(1000);
                });
            var _numbers = Enumerable.Range(0, 10);
            Parallel.ForEach(_numbers,i =>
            {
                Thread.Sleep(1000);
            });

        }
    }
}
