using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadApp_1_15
{
    static class Program
    {
        public static void Main(string[] args)
        {
            Task<int>[] _tasks = new Task<int>[3];

            _tasks[0] = Task.Run(() => { Thread.Sleep(2000); return 1; });
            _tasks[1] = Task.Run(() => { Thread.Sleep(1000); return 2; });
            _tasks[2] = Task.Run(() => { Thread.Sleep(3000); return 3; });

            while (_tasks.Length > 0)
            {
                int i = Task.WaitAny(_tasks);
                Task<int> _completedTask = _tasks[i];
                Console.WriteLine(_completedTask.Result);

                var _temp = _tasks.ToList();
                _temp.RemoveAt(i);
                _tasks = _temp.ToArray();
            }
//            Console.ReadKey();
        }
    }
}
