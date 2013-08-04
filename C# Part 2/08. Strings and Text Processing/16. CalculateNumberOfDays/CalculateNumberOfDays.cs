using System;
using System.Globalization;

//Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.

class CalculateNumberOfDays
{
    static void Main()
    {
        Console.Write("Enter the first date:");
        string startDate = Console.ReadLine();
        DateTime dateBegin = DateTime.ParseExact(startDate, "dd.MM.yyyy", CultureInfo.InvariantCulture);
        Console.Write("Enter the second date:");
        string endDate = Console.ReadLine();

        DateTime dateEnd = DateTime.ParseExact(endDate, "dd.MM.yyyy", CultureInfo.InvariantCulture);

        int days = Math.Abs((dateEnd - dateBegin).Days);
        Console.WriteLine("Distance: {0} days", days, dateBegin, dateEnd);

    }
}

