using System;

class ConvertingToRandomNumSystem
{
    //Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤  16).

    static int ConvertToDecimal(int system, string number)
    {
        int result = 0;
        number = number.ToUpper();
        for (int i = number.Length - 1, counter = 0; i >= 0; i--, counter++)
        {
            int powered = (int)Math.Pow(system, counter);
            if (Char.IsLetter(number[i]) == false)
            {
                string temp = number[i].ToString();
                result += int.Parse(temp) * powered;
            }
            else
            {
                int letterToNum = ((int)number[i]) - 55;
                result += letterToNum * powered;
            }
        }
        return result;
    }

    static void FromDecimalToX(int decim, int outputSystem)
    {
        string result = "";
        string reversedResult = "";
        while (decim > 0)
        {
            result += decim % outputSystem;
            decim /= outputSystem;
        }
        for (int i = result.Length - 1; i >= 0; i--)
        {
            reversedResult += result[i];
        }
        Console.WriteLine("Number in {0} numeral system = {1}",outputSystem, reversedResult);
    }


    static void Main()
    {
        Console.Write("Numeral system of your number: ");
        int inputSystem = int.Parse(Console.ReadLine());

        Console.Write("Number = ");
        string inputNumber = Console.ReadLine();

        Console.Write("To what numeral system do you want to convert your number: ");
        int outputSystem = int.Parse(Console.ReadLine());

        FromDecimalToX(ConvertToDecimal(inputSystem, inputNumber), outputSystem);
        
    }
}

