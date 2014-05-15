using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;

namespace Async_Await_2
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            string _result = DownloadContent().Result;
            Console.WriteLine(_result);
            Console.ReadKey();
        }

        /*public Task SleepAsyncA(int millisecondsTimeOut)
        {
            return Task.Run(() => Thread.Sleep(millisecondsTimeOut));
        }

        public Task SleepAsyncB(int millisecondsTimeout)
        {
            TaskCompletionSource<bool> _tcs = null;
            var t = new Timer(delegate { _tcs.TrySetResult(true); }, null, -1, -1);
            _tcs = new TaskCompletionSource<bool>(t);
            t.Change(millisecondsTimeout, -1);
            return _tcs.Task;
        }
*/
        public static async Task<string> DownloadContent()
        {
            using (HttpClient _client = new HttpClient())
            {
                string _result = await _client.GetStringAsync("http://www.microsoft.com");
                return _result;
            }
        }


    }
}

