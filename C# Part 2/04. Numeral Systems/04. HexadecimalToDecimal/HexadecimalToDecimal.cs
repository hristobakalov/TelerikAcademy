using System;

class HexadecimalToDecimal
{
    //Write a program to convert hexadecimal numbers to their decimal representation.

    static void Main()
    {
        Console.Write("Number in hexadecimal numeral system: ");
        string numberHex = Console.ReadLine();
        numberHex = numberHex.ToUpper();
        int numberDecimal = 0;
        for (int i = numberHex.Length - 1, power = 0; i >= 0; i--, power++)
        {
            if (numberHex[i] == 'A')
            {
                int pow = (int)Math.Pow(16, power);
                numberDecimal += pow * 10;
            }
            else if (numberHex[i] == 'B')
            {
                int pow = (int)Math.Pow(16, power);
                numberDecimal += pow * 11;
            }
            else if (numberHex[i] == 'C')
            {
                int pow = (int)Math.Pow(16, power);
                numberDecimal += pow * 12;
            }
            else if (numberHex[i] == 'D')
            {
                int pow = (int)Math.Pow(16, power);
                numberDecimal += pow * 13;
            }
            else if (numberHex[i] == 'E')
            {
                int pow = (int)Math.Pow(16, power);
                numberDecimal += pow * 14;
            }
            else if (numberHex[i] == 'F')
            {
                int pow = (int)Math.Pow(16, power);
                numberDecimal += pow * 15;
            }
            else
            {
                int digit = int.Parse(Convert.ToString(numberHex[i]));
                int pow = (int)Math.Pow(16, power);
                numberDecimal += pow * digit;
            }
        }
        Console.WriteLine("Your number converted in decimal numeral system is : {0}", numberDecimal);
    }
}

