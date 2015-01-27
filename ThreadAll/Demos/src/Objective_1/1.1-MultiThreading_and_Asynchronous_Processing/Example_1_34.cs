
namespace Demos.src.Objective_1._1._3_Implement_program_Flow
{
    class Example_1_34
    {
        /*
         1 -34 - Using a Concurrent Dictionary
using System;
using System.Collections.Concurrent;

namespace Demos
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var dictionary = new ConcurrentDictionary<string, int>();
            if (dictionary.TryAdd("k1",42))
            {
                Console.WriteLine("Added");
            }

            if (dictionary.TryUpdate("k1",21,42))
            {
                Console.WriteLine("42 updated to 21");
            }

            dictionary["k1"] = 42; // overwrite Inconditionally
            Console.WriteLine("Result after Override: {0}",dictionary["k1"]);

            int r1 = dictionary.AddOrUpdate("k1", 3, (s, i) => i * 2);
            int r2 = dictionary.GetOrAdd("k2", 3);

            Console.WriteLine("Result after AddOrUpdate: {0}", dictionary["k1"]);

        }
    }
}
         
         */
    }
}
