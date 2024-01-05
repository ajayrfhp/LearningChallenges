using FileAsyncApp;



AsyncHelper asyncHelper = new AsyncHelper();
asyncHelper.AsyncDemo("C:\\Users\\ajviswan\\source\\repos\\LearningChallenges\\FileAsyncApp\\TextFile1.txt");


asyncHelper.ReadFile("C:\\Users\\ajviswan\\source\\repos\\LearningChallenges\\FileAsyncApp\\TextFile1.txt");
asyncHelper.ReadFile("C:\\Users\\ajviswan\\source\\repos\\LearningChallenges\\FileAsyncApp\\TextFile2.txt");


await asyncHelper.ReadFileASync("C:\\Users\\ajviswan\\source\\repos\\LearningChallenges\\FileAsyncApp\\TextFile1.txt");

string result = await asyncHelper.SimulateNetworkCallAsync();

Console.WriteLine(result);

Console.ReadKey();