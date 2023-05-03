using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP_WebAPI.Language_Features
{
    internal class AsyncAwait
    {
        private readonly DatabaseConnection _context;
        public AsyncAwait(DatabaseConnection context)
        {
            _context = context;
        }

        public async Task<List<string>> GetWebsites()
        {
            List<string> websites = new List<string>();


            var task1 = Task1Async(websites);
            var task2 = Task2Async(websites);

            await Task.WhenAll(task1, task2);

            return websites;
        }

        public async Task Task1Async(List<string> websites)
        {
            var client = new HttpClient();

            var task1 = await client.GetStringAsync("https://www.microsoft.com");
            websites.Add(task1);
        }

        public async Task Task2Async(List<string> websites)
        {
            var client = new HttpClient();

            var task2 = await client.GetStringAsync("https://www.google.com");
            websites.Add(task2);
        }
    }
}
