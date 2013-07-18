using System;

class CheckThirdDigit
{
    static void Main()
    //Write an expression that checks for given integer if its third digit (right-to-left) is 7. E. g. 1732  true.

    {
        Console.WriteLine("Please insert a number!");
        int number = int.Parse(Console.ReadLine());
        int shorterNumber = number / 100;
        int mask = 7;
        int nAndMask = shorterNumber & mask;
        bool thirdDigitIs7 = nAndMask == 7;
        Console.WriteLine(thirdDigitIs7);
    }
}

