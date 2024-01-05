// See https://aka.ms/new-console-template for more information
using WebAsyncApp;

Console.WriteLine("Hello, World!");

double duration;
DateTime start;
DateTime end;

Requests requests = new Requests();
start = DateTime.Now;
requests.DoSyncWork();
end = DateTime.Now;
duration = (end - start).TotalMilliseconds;
Console.WriteLine("Sync work took {0} \n\n", duration);

start = DateTime.Now;
await requests.DoAsyncWork();
end = DateTime.Now;
duration = (end - start).TotalMilliseconds;
Console.WriteLine("ASync work took {0}", duration);


