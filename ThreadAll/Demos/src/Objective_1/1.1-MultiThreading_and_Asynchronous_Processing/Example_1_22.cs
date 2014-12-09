//1.22 Using AsParallel
/*
using System;
using System.Linq;

namespace Demos
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var numbers = Enumerable.Range(0, 100000000);
            var parallelResult = numbers.AsParallel()
                .Where(i => i % 2 == 0)
                .ToArray();
            foreach (int _number in parallelResult)
            {
                Console.WriteLine("Number {0}", _number);
            }
            Console.ReadKey();
        }
    }
}
*/