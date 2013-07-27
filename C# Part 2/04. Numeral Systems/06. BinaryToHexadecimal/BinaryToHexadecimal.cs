using System;

class BinaryToHexadecimal
{
    //Write a program to convert binary numbers to hexadecimal numbers (directly).

    static void Main()
    {
        Console.WriteLine("Insert a number in binary numeral system!");
        string numberBinary = Console.ReadLine();
        string numberHex = "";

        int leftover = (numberBinary.Length) % 4;
        int numberDecimal = 0;

        for (int i = 4; i <= numberBinary.Length - leftover; i += 4)
        {
            for (int k = i - 1, power = 0; k >= i - 4; k--, power++)
            {
                if (numberBinary[k] == '1')
                {
                    int pow = (int)Math.Pow(2, power);
                    numberDecimal += pow;
                }
            }
            if (numberDecimal < 10)
            {
                numberHex += numberDecimal;
            }
            else if (numberDecimal == 10)
            {
                numberHex += "A";
            }
            else if (numberDecimal == 11)
            {
                numberHex += "B";
            }
            else if (numberDecimal == 12)
            {
                numberHex += "C";
            }
            else if (numberDecimal == 13)
            {
                numberHex += "D";
            }
            else if (numberDecimal == 14)
            {
                numberHex += "E";
            }
            else if (numberDecimal == 15)
            {
                numberHex += "F";
            }
            numberDecimal = 0;
        }

        if (leftover != 0)
        {
            for (int i = numberBinary.Length - 1, power = 0; i >= numberBinary.Length - leftover; i--, power++)
            {

                if (numberBinary[i] == '1')
                {
                    int pow = (int)Math.Pow(2, power);
                    numberDecimal += pow;
                }
            }
            numberHex += numberDecimal;
        }
        Console.WriteLine("Number in hexadecimal numeral system: {0}", numberHex);
    }
}

