namespace Demos.src.Objective_1._1._1_MultiThreading_and_Asynchronous_Processing
{
//1.27 Catching AggregateException - Two Exceptions Will Ocurr while processing the Data
    /* 
using System;
using System.Linq;

namespace Demos
{
    public class Program
    {
        public static bool IsEven(int i)
        {
            if (i % 10 == 0)
                throw new ArgumentException("i");
            return i % 2 == 0;
        }

        public static void Main(string[] args)
        {
            var numbers = Enumerable.Range(0, 20);
            try
            {
                var parallelResult = numbers.AsParallel()
                    .Where(i => IsEven(i));
                parallelResult.ForAll(e => Console.WriteLine("Number {0}", e));
            }
            catch (AggregateException e)
            {
                Console.WriteLine("There Where {0} exceptions", e.InnerExceptions.Count());
            }
            Console.ReadKey();
        }
    }
}

    */
}
