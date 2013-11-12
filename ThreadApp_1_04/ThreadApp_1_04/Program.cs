using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ThreadApp_1_04
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
            bool _stopped = false;

            Thread _t = new Thread(new ThreadStart(() =>
            {
                while (!_stopped)
                {
                    Console.WriteLine("Running...");
                    Thread.Sleep(1000);
                }
            }));
            _t.Start();
            Console.WriteLine("Press Any Key To Exit");
            Console.ReadKey();

            _stopped = true;

            _t.Join(); // faz com que o processo rode ate que seja finalizada a outra thread
        }
    }
}
