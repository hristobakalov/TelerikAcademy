using System;
//Write a program that reads a year from the console and checks whether it is a leap. Use DateTime.

class LeapYear
{
    static void Main()
    {
        Console.Write("Insert a year: ");
        int year = int.Parse(Console.ReadLine());
        if (DateTime.IsLeapYear(year))
        {
            Console.WriteLine("The year is leap!");
        }
        else
        {
            Console.WriteLine("The year isn't leap!");
        }
    }
}

