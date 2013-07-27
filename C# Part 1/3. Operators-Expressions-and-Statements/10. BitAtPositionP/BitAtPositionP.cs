using System;

class BitAtPositionP
{
    static void Main()
    //Write a boolean expression that returns if the bit at position p (counting from 0)
    //in a given integer number v has value of 1. Example: v=5; p=1  false.

    {
        int p = 1; //<-- here you write the position
        int v = 5; //<-- here you write the number
        int mask = 1 << p;
        int vAndMask = v & mask;
        int bit = vAndMask >> p;
        if (bit == 1)
        {
            Console.WriteLine("True");
            return;
        }
        else if (bit == 0)
        {
            Console.WriteLine("False");
            return;
        }
        else
        {
            Console.WriteLine("There is some mistake.");
        }
        return;
    }
}

