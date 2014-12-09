namespace Demos.src.Objective_1._1._1_MultiThreading_and_Asynchronous_Processing
{
    //1.25 Making a Parallel Query Sequential
    /*
using System;
using System.Linq;

namespace Demos
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var numbers = Enumerable.Range(0, 20);
            var parallelResult = numbers.AsParallel()
                .AsOrdered()
                .Where(i => i % 2 == 0)
                .AsSequential();
            foreach (int _number in parallelResult.Take(5))
            {
                Console.WriteLine("Number {0}",_number);
            }
            Console.ReadKey();
        }
    }
}

    */

}
