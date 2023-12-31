// See https://aka.ms/new-console-template for more information

Console.WriteLine("Type birthday in yyyy-mm-dd");
string birthdayString = Console.ReadLine();
try
{
    DateTime birthday = DateTime.ParseExact(birthdayString, "yyyy-M-d", null);
    DateTime currentDay = DateTime.UtcNow;

    (int years, int months, int days) = SubtractDates(currentDay, birthday);
    Console.WriteLine("You are {0} years {1} months {2} days old", years, months, days);

    DateTime nextBirthDay = new DateTime(currentDay.Year+1, birthday.Month, birthday.Day);
    (years, months, days) = SubtractDates(nextBirthDay, currentDay);
    Console.WriteLine("Next birthday in {0} years {1} months and {2} days", years, months, days);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

(int, int, int) SubtractDates(DateTime date1, DateTime date2)
{
    if (date1 < date2)
    {
        throw new ArgumentOutOfRangeException("You are not yet born");
    }
    TimeSpan diff = date1 - date2;

    int carry = 0;
    int days_diff = date1.Day - date2.Day;
    if(days_diff < 0)
    {
        carry = 1;
        days_diff = DateTime.DaysInMonth(date2.Year, date2.Month) + days_diff;
    }
    int months_diff = date1.Month - date2.Month - carry;
    carry = 0;
    if(months_diff < 0) 
    {
        months_diff = 12 + months_diff;
        carry = 1;
    }
    int years_diff = date1.Year - date2.Year - carry;


    return (years_diff, months_diff, days_diff);
}