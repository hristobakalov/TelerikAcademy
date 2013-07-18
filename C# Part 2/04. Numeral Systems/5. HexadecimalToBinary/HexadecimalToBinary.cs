using System;

class HexadecimalToBinary
{
    //Write a program to convert hexadecimal numbers to binary numbers (directly).

    static void Main()
    {
        Console.Write("Number in hexadecimal numeral system: ");
        string numberHex = Console.ReadLine();
        numberHex = numberHex.ToUpper();
        string numberToBinary = "";
        for (int i = 0; i < numberHex.Length; i++)
        {
            if (numberHex[i] == 'A')
            {  
                numberToBinary += Convert.ToString(10, 2).PadLeft(4, '0');
            }
            else if (numberHex[i] == 'B')
            {
                numberToBinary += Convert.ToString(11, 2).PadLeft(4, '0');
            }
            else if (numberHex[i] == 'C')
            {
                numberToBinary += Convert.ToString(12, 2).PadLeft(4, '0');
            }
            else if (numberHex[i] == 'D')
            {
                numberToBinary += Convert.ToString(13, 2).PadLeft(4, '0');
            }
            else if (numberHex[i] == 'E')
            {
                numberToBinary += Convert.ToString(14, 2).PadLeft(4, '0');
            }
            else if (numberHex[i] == 'F')
            {
                numberToBinary += Convert.ToString(15, 2).PadLeft(4, '0');
            }
            else
            {
                int digit = int.Parse(Convert.ToString(numberHex[i]));
                numberToBinary += Convert.ToString(digit, 2).PadLeft(4, '0');
            }
        }
        Console.WriteLine("Number to binary numeral system: {0}", numberToBinary);
    }
}

