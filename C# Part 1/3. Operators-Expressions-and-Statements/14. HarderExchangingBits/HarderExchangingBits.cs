using System;

class HarderExchangingBits
{
    static void Main()
    //Write a program that exchanges bits {p, p+1, …, p+k-1) with bits {q, q+1, …, q+k-1} of given 32-bit unsigned integer.

    {
        Console.Write("Insert a number - ");
        uint number = uint.Parse(Console.ReadLine());
        uint originalNumber = number;
        Console.Write("Insert how many bits do you want to exchange - ");
        int k = int.Parse(Console.ReadLine());
        Console.Write("Insert the position p on the first bits - ");
        int p = int.Parse(Console.ReadLine());
        Console.Write("Insert the position q which you want to be switched - ");
        int q = int.Parse(Console.ReadLine());

        for (uint i = 0; i < k; i++)
        {
            uint mask1 = (uint)1 << p; // 1 is booted to bit on position p
            uint numberAndMask1 = number & mask1; // gets the value of the bit on position p
            uint bitOnPPosition = numberAndMask1 >> p; // the bit is returned to position 0

            uint mask2 = (uint)1 << q; // sends 1 to position q;
            uint numberAndMask2 = number & mask2; // gets the value of the bit on position q
            uint bitOnQPosition = numberAndMask2 >> q; // returns the bit on position 0

            if (bitOnPPosition == 0)
            {
                number = ~(uint)(1 << q) & number; //using a construction IF to check if the bit on position p is 0 if it is, 
                //than we send 1 to q position invert it use the bitwise operator "logical and" it by the number
            }
            else
            {
                number = (uint)(1 << q) | number; // if the bit on position p is 1 than we send it to position q and use the bitwise operator "OR"
            }

            if (bitOnQPosition == 0)
            {
                number = ~(uint)(1 << p) & number; // we do the same thing with the bit from position q 
            }
            else
            {
                number = (uint)(1 << p) | number; 
            }
            p++;
            q++;
        }
        Console.WriteLine("Before the switch:  {0}", Convert.ToString(originalNumber, 2).PadLeft(32, '0'));
        Console.WriteLine("After the switch:   {0}", Convert.ToString(number, 2).PadLeft(32, '0'));
    }
}
