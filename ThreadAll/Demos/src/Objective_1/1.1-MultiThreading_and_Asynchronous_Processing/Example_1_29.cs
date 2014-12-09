namespace Demos.src.Objective_1._1._1_MultiThreading_and_Asynchronous_Processing
{
//1.29 Using GetConsumingEnumerable on A BlockingCollection
    /*
    using System;
    using System.Collections.Concurrent;
    using System.Threading.Tasks;

    namespace Demos
    {
        public class Program
        {
            public static void Main(string[] args)
            {
                BlockingCollection<string> columns = new BlockingCollection<string>();
                Task read = Task.Run(() =>
                    {
                        foreach (string v in columns.GetConsumingEnumerable())
                            Console.WriteLine(v);
                    });

                Task write = Task.Run(() =>
                    {
                        while (true)
                        {
                            string s = Console.ReadLine();
                            if (string.IsNullOrEmpty(s)) break;
                            columns.Add(s);
                        }
                    });
                write.Wait();
                Console.ReadKey();
            }
        }
    }
 */
}
