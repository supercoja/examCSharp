﻿namespace Demos.src.Objective_1._1._1_MultiThreading_and_Asynchronous_Processing
{
    //1.10 Adding a Continuation

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
                }).ContinueWith((i) =>
                    {
                        return i.Result * 2;
                    });
            Console.WriteLine(t.Result);
            Console.ReadKey();
        }
    }
}

     */
}
