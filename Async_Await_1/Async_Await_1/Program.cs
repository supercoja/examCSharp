using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Async_Await_1
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            string _result = DownloadContent().Result;
            Console.WriteLine(_result);
            Console.ReadKey();
        }

        public static async Task<string> DownloadContent()
        {
            using (HttpClient _client = new HttpClient())
            {
                string _result = await _client.GetStringAsync("http://www.microsoft.com");
                return _result;
            }
        }

        public void FunctionA(int _number)
        {
            _number = 10;
        }

        public void FunctionB(ref int _number)
        {
            _number = 10;
        }

                    List<string> productsList = new List<string>();

            try
            {
                using (AdventureWorks2012Entities database = new AdventureWorks2012Entities())
                {
                    var products = from product in database.Products
                                   select product.ProductNumber;

                    productsList = products.ToList();
                }
            }
            catch
            {

            }




    }

}
