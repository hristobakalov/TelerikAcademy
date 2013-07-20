using System;
//Write a method that calculates the number of workdays between today and given date, passed as parameter.
//Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.

class CalculateWorkdays
{
    static void Main()
    {
        Console.Write("Insert a date (in format YYYY/MM/DD) : ");
        string[] endDateArray = Console.ReadLine().Split('/');
        int day = int.Parse(endDateArray[2]);
        int month = int.Parse(endDateArray[1]);
        int year = int.Parse(endDateArray[0]);

        DateTime today = DateTime.Today;
        DateTime endDate = new DateTime(year, month, day);

        int dayLength = Math.Abs((endDate - today).Days);

        int workDays = 0;

        //this are some random holidays
        DateTime[] holidays = 
        {
            new DateTime(2013,07,15),
            new DateTime(2013,08,01),
            new DateTime(2013,08,21),
            new DateTime(2013,08,09),
            new DateTime(2013,09,15),
            new DateTime(2013,10,11),
        };

        bool IsHoliday = false;

        for (int i = 0; i < dayLength; i++)
        {
            DateTime checkDate = today.AddDays(1 + i);

            for (int k = 0; k < holidays.Length; k++)
            {
                if (checkDate == holidays[k])
                {
                    IsHoliday = true;
                    break;
                }
            }
            
            if ((checkDate.DayOfWeek != DayOfWeek.Saturday) && (checkDate.DayOfWeek != DayOfWeek.Sunday) && !IsHoliday)
            {
                workDays++;
            }
            IsHoliday = false;
        }
        Console.WriteLine("In the period {0} to {1},\nthere are {2} working days!",today, endDate, workDays);


        

    }
}

