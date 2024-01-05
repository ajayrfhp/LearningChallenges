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
                "https://www.gutenberg.org/cache/epub/2701/pg2701.txt",
                "https://www.gutenberg.org/cache/epub/1342/pg1342.txt",
                "https://www.gutenberg.org/cache/epub/1513/pg1513.txt",
                "https://www.gutenberg.org/cache/epub/145/pg145.txt"
            };
        }

        public void DoSyncWork()
        {
            foreach (string file in files)
            {
                this.HttpClient.GetAsync(file).Wait();
                Console.WriteLine("Downloaded data for {0}", file);
            }
        }

        public void DoASyncWork()
        {
            foreach (string file in files)
            {
                this.HttpClient.GetAsync(file).Wait();
                Console.WriteLine("Downloaded data for {0}", file);
            }
        }

    }
}
