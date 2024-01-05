// See https://aka.ms/new-console-template for more information
using WebAsyncApp;


Requests requests = new Requests();


DateTime start = DateTime.Now;
requests.DoSyncWork();
DateTime end = DateTime.Now;
double duration = (end - start).TotalSeconds;
Console.WriteLine("Sync work completed in {0} seconds", duration);

start = DateTime.Now;
requests.DoASyncWork();
end = DateTime.Now;
duration = (end - start).TotalSeconds;
Console.WriteLine("ASync work completed in {0} seconds", duration);
