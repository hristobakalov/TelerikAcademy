using System;

class DecimalToHexadecimal
{
    //Write a program to convert decimal numbers to their hexadecimal representation.

    static void Main()
    {
        Console.WriteLine("Insert a number in decimal numeral system!");
        int numberDecimal = int.Parse(Console.ReadLine());
        Console.WriteLine("Your number in hexadecimal numeral system: {0}", Convert.ToString(numberDecimal, 16).ToUpper());
    }
}

