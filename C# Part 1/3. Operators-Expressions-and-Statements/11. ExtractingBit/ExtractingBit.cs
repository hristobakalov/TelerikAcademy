using System;

class ExtractingBit
{
    static void Main()
    //Write an expression that extracts from a given integer i the value of a given bit number b. Example: i=5; b=2  value=1.

    {
        int b = 14; //<-- here you write the position
        int i = 33363; //<-- here you write the number
        int mask = 1 << b;
        int iAndMask = i & mask;
        int bit = iAndMask >> b;
        Console.WriteLine("The bit on {0} position of the number {1} is: {2}", b, i, bit);
    }
}
