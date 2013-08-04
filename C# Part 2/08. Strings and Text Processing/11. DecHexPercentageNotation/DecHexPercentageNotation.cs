using System;

//Write a program that reads a number and prints it as a decimal number, hexadecimal number, percentage
//and in scientific notation. Format the output aligned right in 15 symbols.

class DecHexPercentageNotation
{
    static void Main()
    {
        string input = Console.ReadLine();
        int number = int.Parse(input);
        Console.WriteLine("{0,15}", number);   // Decimal

        Console.WriteLine("{0,15:X}", number); // Hexadecimal

        Console.WriteLine("{0,15:P}", number); // Percentage

        Console.WriteLine("{0,15:E}", number); // Scientific notation
    }
}

