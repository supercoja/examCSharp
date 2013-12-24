using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadApp_1_08
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Task t = Task.Run(() =>
                {
                    for (int x = 0; x < 100; x++)
                    {
                        Console.WriteLine("* {0}",x);
                    }
                });
            t.Wait();
            Console.ReadKey();
        }
    }
}
