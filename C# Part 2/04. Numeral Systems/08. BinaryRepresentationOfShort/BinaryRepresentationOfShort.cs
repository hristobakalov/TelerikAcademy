using System;

class BinaryRepresentationOfShort
{
    //Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).

    static void Main()
    {
        short number = short.Parse(Console.ReadLine());
        Console.WriteLine("Your number in binary numeral system: {0}", Convert.ToString(number, 2).PadLeft(16, '0'));
    }
}

