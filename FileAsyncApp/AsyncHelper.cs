using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileAsyncApp
{
    public class AsyncHelper
    {
        public void ReadFile(string file)
        {
            // Do ASYNC programming without ASYNC and AWAIT. This is in c#. 
            File.ReadAllLinesAsync(file).
                ContinueWith(t =>
                {
                    if (t.IsFaulted)
                    {
                        Console.Error.WriteLine(t.Exception.Message);
                        return;
                    }
                    Console.WriteLine("Status from complete with{0}", t.Result);
                });
        }

        public async Task ReadFileASync(string file)
        {
            var lines = await File.ReadAllLinesAsync(file);
            foreach (var line in lines)
            {
                Console.WriteLine(line.ToString());
            }
        }

        public void AsyncDemo(string file)
        {
            var readFileTask = File.ReadAllLinesAsync(file);

            Console.WriteLine(readFileTask.Status); // Should say waiting for activation
            Thread.Sleep(1000);
            Console.WriteLine(readFileTask.Status); // Should say completed

            var readFileTask2 = File.ReadAllLinesAsync(file);
            readFileTask2.Wait(); // This is a blocking operation. Bad idea
            Console.WriteLine(readFileTask2.Status);
        }

        public async Task<string> SimulateNetworkCallAsync()
        {
            await Task.Delay(100);
            var result = "Network call has been completed";
            return result;
        }
    }

}
