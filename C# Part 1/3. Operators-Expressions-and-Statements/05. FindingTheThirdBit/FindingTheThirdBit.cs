using System;

class FindingTheThirdBit
{
    static void Main()
    //Write a boolean expression for finding if the bit 3 (counting from 0) of a given integer is 1 or 0.

    {
        Console.WriteLine("Please insert a number!");
        int n = int.Parse(Console.ReadLine());
        int mask = 1 << 3;
        int nAndMask = n & mask;
        int bit = nAndMask >> 3;
        Console.WriteLine("The 3rd bit of your number is: {0}", bit);
    }
}

