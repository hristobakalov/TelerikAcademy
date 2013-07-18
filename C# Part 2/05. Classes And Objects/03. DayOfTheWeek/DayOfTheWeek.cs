using System;
//Write a program that prints to the console which day of the week is today. Use System.DateTime.

class DayOfTheWeek
{
    static void Main()
    {
        DateTime dateNow = DateTime.Now;
        DayOfWeek dayToday = dateNow.DayOfWeek;
        Console.WriteLine("Today is: {0}", dayToday);
    }
}

