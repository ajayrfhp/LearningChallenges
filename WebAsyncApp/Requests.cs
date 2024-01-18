using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAsyncApp
{
    public class Requests
    {
        public HttpClient HttpClient { get; set; }

        public List<string> files { get; set; }

        public Requests()
        {
            this.HttpClient = new HttpClient();
            this.files = new List<string>
            {
                "https://filesamples.com/samples/document/txt/sample1.txt",
                "https://filesamples.com/samples/document/txt/sample2.txt",
                "https://filesamples.com/samples/document/txt/sample3.txt"
            };
        }

        public void DoSyncWork()
        {
            foreach (string file in files)
            {
                Console.WriteLine("Begining Sync download for {0}", file);
                this.HttpClient.GetAsync(file).Wait();
                Console.WriteLine("Downloaded Sync data for {0}", file);
            }
        }

        public async Task DoAsyncWork()
        {
            List<Task> tasks = new List<Task>();
            foreach (string file in files)
            {
                Console.WriteLine("Begining Async download for {0}", file);
                tasks.Add(this.HttpClient.GetAsync(file));
                Console.WriteLine("Downloaded Async data for {0}", file);
            }
            await Task.WhenAll(tasks);
        }

    }
}
