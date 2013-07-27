using System;

class DividingBySevenAndFive
{
    static void Main()
    //Write a boolean expression that checks for given integer if it can be divided
    //(without remainder) by 7 and 5 in the same time.

    {
        Console.WriteLine("Please write down a number!");
        int a = int.Parse(Console.ReadLine());
        bool result = (a % 7 == 0) & (a % 5 == 0);
        Console.WriteLine(result);
    }
}

