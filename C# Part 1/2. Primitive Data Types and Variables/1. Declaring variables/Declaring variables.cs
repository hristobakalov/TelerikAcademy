using System;


class Program
{
    static void Main()
    //Declare five variables choosing for each of them the most appropriate of the types
    //byte, sbyte, short, ushort, int, uint, long, ulong to represent the following values: 52130, -115, 4825932, 97, -10000.

    {
        byte a = 97;
        sbyte b = -115;
        ushort c = 52130;
        short d = -10000;
        int e = 4825932;
        Console.WriteLine("byte a = {0}, sbyte b = {1}, ushort c = {2}, short d = {3}, int e = {4}", a, b, c, d, e);
    }
}

