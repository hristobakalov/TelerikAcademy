using System;

class HoldingValue
{
    static void Main()
    //We are given integer number n, value v (v=0 or 1) and a position p.
    //Write a sequence of operators that modifies n to hold 
    //the value v at the position p from the binary representation of n.

    {
        Console.Write("Please enter a number n=");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));
        Console.Write("Please eneter a possition p=");
        int p = int.Parse(Console.ReadLine());
        Console.Write("Please eneter v=");
        int v = int.Parse(Console.ReadLine());
        n = n & (~(1 << p));
        Console.WriteLine(Convert.ToString((~(1 << p)), 2).PadLeft(32, '0'));
        Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));
        n = n | (v << (p));
        Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));
        Console.WriteLine("{0}", n);
    }
}

