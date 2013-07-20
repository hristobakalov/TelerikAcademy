using System;

class DecimalToBinary
{
    //Write a program to convert decimal numbers to their binary representation.

    static void Main()
    {
        Console.WriteLine("Insert a number in decimal numeral system!");
        int numberDecimal = int.Parse(Console.ReadLine());
        Console.WriteLine("Your number in binary numeral system: {0}", Convert.ToString(numberDecimal, 2).PadLeft(32, '0'));
    }
}

