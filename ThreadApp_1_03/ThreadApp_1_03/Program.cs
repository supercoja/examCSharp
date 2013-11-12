using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ThreadApp_1_03
{
    public static class Program
    {
        public static void ThreadMethod(object _o)
        {
            for (int i = 0; i < (int)_o; i++)
            {
                Console.WriteLine("ThreadProc: {0} ", i);
                Thread.Sleep(0); // sinal de aviso ao windows que a Thread foi finalizada e que pode ser liberado o "time slice" alocado para a thread 
            }
        }

        public static void Main(string[] args)
        {
            Thread _t = new Thread(new ParameterizedThreadStart(ThreadMethod));
            _t.Start(10);
            _t.Join();
            Console.ReadLine();
        }
    }
}
