using System;

class BinaryToDecimal
{
    //Write a program to convert binary numbers to their decimal representation.

    static void Main()
    {
        Console.WriteLine("Insert a number in binary numeral system!");
        string numberBinary = Console.ReadLine();
        int numberDecimal = 0;
        for (int i = numberBinary.Length - 1, power = 0; i >= 0; i--,power++)
        {
            if (numberBinary[i] == '1')
            {
                int pow = (int)Math.Pow(2, power);
                numberDecimal += pow;
            }
            else if (numberBinary[i] == '0')
            {
                continue;
            }
            else
            {
                Console.WriteLine("A binary number consists only of 0 and 1!");
                return;
            }
        }
        Console.WriteLine("Your number converted in decimal numeral system is : {0}", numberDecimal);
        
    }
}

