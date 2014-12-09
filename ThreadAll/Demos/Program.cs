using System;
using System.Collections.Concurrent;
using System.Threading.Tasks;

namespace Demos
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var bagOfBaggins = new ConcurrentBag<int>();

            bagOfBaggins.Add(42);
            bagOfBaggins.Add(21);
            int result;
            if (bagOfBaggins.TryTake(out result))
                Console.WriteLine(result);

            if (bagOfBaggins.TryPeek(out result))
                Console.WriteLine("There is A Next Item {0}",result);

            Console.ReadKey();

        }
    }
}
