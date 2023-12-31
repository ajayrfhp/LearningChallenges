// See https://aka.ms/new-console-template for more information
string inputDateString = Console.ReadLine();
try
{
    DateTime inputDate = DateTime.ParseExact(inputDateString, "M/d/yy h:m:s", null);
    DateTime currentDate = DateTime.Now;
    TimeSpan difference = currentDate - inputDate;
    Console.WriteLine("Given date was {0} days {1} hours {2} minutes {3} seconds", difference.Days, difference.Hours, difference.Minutes, difference.Seconds);
}
catch (Exception ex)
{
    Console.WriteLine(ex); 
}

