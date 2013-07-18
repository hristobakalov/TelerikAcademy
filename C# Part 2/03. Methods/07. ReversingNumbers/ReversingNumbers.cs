using System;

class ReversingNumbers
{
    //Write a method that reverses the digits of given decimal number. Example: 256  652

    static string ReversNumber(decimal number)
    {
        string numberToString = number.ToString();
        string numberWithoutComa = "";
        for (int i = numberToString.Length - 1; i >= 0; i--)
        {
            if (numberToString[i] != ',')
            {
                    numberWithoutComa += numberToString[i];
            }
            else
            {
                numberWithoutComa += ",";
            }
        }
        return numberWithoutComa;
    }

    static void Main()
    {
        Console.Write("Number = ");
        decimal n = decimal.Parse(Console.ReadLine());
        Console.WriteLine(ReversNumber(n));
    }
}

