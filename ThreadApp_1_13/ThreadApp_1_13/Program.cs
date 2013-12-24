using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadApp_1_13
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Task<Int32[]> _parent = Task.Run(() =>
                {
                    var _results = new Int32[3];
                    TaskFactory _taskF = new 
                    TaskFactory(TaskCreationOptions.AttachedToParent,TaskContinuationOptions.ExecuteSynchronously);

                    _taskF.StartNew(() => _results[0] = 0);
                    _taskF.StartNew(() => _results[1] = 1);
                    _taskF.StartNew(() => _results[2] = 2);

                    return _results;
                });
               var _finalTask = _parent.ContinueWith(
                   _parentTask => {
                       foreach (int i in _parentTask.Result)
                           Console.WriteLine(i);
                   });

                _finalTask.Wait();
                Console.ReadKey();
             
        }
    }
}
