using System;

class ExchangingBits
{
    static void Main()
    //Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.

    {
        uint i = 89156112; //<-- here you write the number
        Console.WriteLine("Before the switch:  {0}", Convert.ToString(i, 2).PadLeft(32, '0'));

        // Now bit 3 will be switched will bit 24

        uint mask1 = 1 << 3; // 1 is booted to bit on position 3
        uint iAndMask1 = i & mask1; // gets the value of the bit on position 3
        uint bitOn3rd = iAndMask1 >> 3; // the bit is returned to position 0

        uint mask2 = 1 << 24; // sends 1 to position 24;
        uint iandMask2 = i & mask2; // gets the value of the bit on position 24
        uint bitOn24th = iandMask2 >> 24; // returns the bit on position 0

        if (bitOn3rd == 0)
        {
            i = ~(uint)(1 << 24) & i; //using a construction IF to check if the bit on position 3 is 0 if it is, 
                                    //than we send 1 to 24th position invert it use the bitwise operator "logical and" it by the number i;
        }
        else
        {
            i = (1 << 24) | i; // if the bit on position 3 is 1 than we send it to position 24 and use the bitwise operator "OR"
        }

        if (bitOn24th == 0 )
        {
            i = ~(uint)(1 << 3) & i; // we do the same thing with the bit from position 24 
        }
        else
        {
            i = (1 << 3) | i;
        }


        //Now bit 4 will be switched with bit 25

        uint mask3 = 1 << 4; // 1 is booted to bit on position 4
        uint iAndMask3 = i & mask3; // gets the value of the bit on position 4
        uint bitOn4rd = iAndMask3 >> 4; // the bit is returned to position 0

        uint mask4 = 1 << 25; // sends 1 to position 25;
        uint iandMask4 = i & mask4; // gets the value of the bit on position 25
        uint bitOn25th = iandMask4 >> 25; // returns the bit on position 0

        if (bitOn4rd == 0)
        {
            i = ~(uint)(1 << 25) & i; //using a construction IF to check if the bit on position 4 is 0 if it is, 
            //than we send 1 to 25th position invert it use the bitwise operator "logical and" it by the number i;
        }
        else
        {
            i = (1 << 25) | i; // if the bit on position 4 is 1 than we send it to position 25 and use the bitwise operator "OR"
        }

        if (bitOn25th == 0)
        {
            i = ~(uint)(1 << 4) & i; // we do the same thing with the bit from position 25 
        }
        else
        {
            i = (1 << 4) | i;
        }

        // Now bit 5 will be switched with bit 26

        uint mask5 = 1 << 5; // 1 is booted to bit on position 5
        uint iAndMask5 = i & mask5; // gets the value of the bit on position 5
        uint bitOn5rd = iAndMask5 >> 5; // the bit is returned to position 0

        uint mask6 = 1 << 26; // sends 1 to position 26;
        uint iandMask6 = i & mask6; // gets the value of the bit on position 26
        uint bitOn26th = iandMask6 >> 26; // returns the bit on position 0

        if (bitOn5rd == 0)
        {
            i = ~(uint)(1 << 26) & i; //using a construction IF to check if the bit on position 5 is 0 if it is, 
            //than we send 1 to 26th position invert it use the bitwise operator "logical and" it by the number i;
        }
        else
        {
            i = (1 << 26) | i; // if the bit on position 5 is 1 than we send it to position 26 and use the bitwise operator "OR"
        }

        if (bitOn26th == 0)
        {
            i = ~(uint)(1 << 5) & i; // we do the same thing with the bit from position 26 
        }
        else
        {
            i = (1 << 5) | i;
        }

        Console.WriteLine("After the switch:   {0}", Convert.ToString(i, 2).PadLeft(32, '0'));
    }
}

