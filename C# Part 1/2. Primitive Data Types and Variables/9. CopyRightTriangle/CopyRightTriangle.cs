using System;

class CopyRightTriangle
{
    static void Main()
    {
        //Write a program that prints an isosceles triangle of 9 copyright symbols ©.
        //Use Windows Character Map to find the Unicode code of the © symbol. Note: the © symbol may be displayed incorrectly.

        char symbol = '\u00A9';
        Console.WriteLine(" " + " " + " " + symbol);
        Console.WriteLine(" " + " " + symbol + symbol + symbol);
        Console.WriteLine(" " + symbol + symbol + symbol + symbol + symbol);
    }
}

