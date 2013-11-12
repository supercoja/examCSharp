using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ThreadStaticField_1_05
{
    public static class Program
    {
//        [ThreadStatic]
        public static int _field;

        public static void Main(string[] args)
        {
            new Thread(() =>
                {
                    for (int x = 0;x<10;x++)
                    {
                        _field++;
                        Console.WriteLine("Thread A: {0}", _field);
                    }
                }).Start();
            new Thread(() =>
                {
                    for (int x = 0; x < 10; x++)
                    {
                        _field++;
                        Console.WriteLine("Thread B: {0}", _field);
                    }
                }).Start();

            Console.ReadKey();
        }
    }
}
