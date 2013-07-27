using System;

class AssigningNullValues
{
    static void Main()
    //Create a program that assigns null values to an integer and to double variables. 
    //Try to print them on the console, try to add some values or the null literal to them and see the result.

    {
        int? a = null;
        double? b = null;
        Console.WriteLine("a = {0}\nb = {1}", a, b);
        Console.WriteLine("After trying to add numbers to them:\na = {0}\nb = {1}", a + 10, b + 0,4);
    }
}

