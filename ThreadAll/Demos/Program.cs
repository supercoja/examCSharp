using System.Threading;

namespace Demos
{
    public class Program
    {
        public static void Main(string[] args)
        {
            object gate = new object();
            bool __lockTaken = false;
            try
            {
                Monitor.Enter(gate, ref __lockTaken);
            }
            finally
            {
                if (__lockTaken)
                    Monitor.Exit(gate);
            }
        }
    }
}
