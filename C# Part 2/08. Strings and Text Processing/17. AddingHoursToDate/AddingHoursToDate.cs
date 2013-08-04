using System;
using System.Globalization;

//Write a program that reads a date and time given in the format: day.month.year hour:minute:second
//and prints the date and time after 6 hours and 30 minutes (in the same format)
//along with the day of week in Bulgarian.

class AddingHoursToDate
{
    static void Main()
    {
        Console.Write("Enter date and time:");
        string startDate = Console.ReadLine();
        DateTime date = DateTime.ParseExact(startDate, "dd.MM.yyyy HH:mm:ss", CultureInfo.DefaultThreadCurrentCulture);

        date = date.AddHours(6);
        date = date.AddMinutes(30);

        Console.WriteLine("Date after 6 hours and 30 mins: {0}", date);
        Console.WriteLine("Day of the week : {0}", date.ToString("dddd", new CultureInfo("bg-BG")));
    }
}

