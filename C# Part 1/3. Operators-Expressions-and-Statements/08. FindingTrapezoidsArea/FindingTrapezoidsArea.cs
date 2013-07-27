using System;

class FindingTrapezoidsArea
{
    static void Main()
    //Write an expression that calculates trapezoid's area by given sides a and b and height h.

    {
        Console.Write("Insert the trapezoids side a!\na = ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Insert the trapezoids side b!\nb = ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Insert the trapezoids height h!\nh = ");
        int h = int.Parse(Console.ReadLine());
        int area = ((a + b) * h) / 2;
        Console.WriteLine("The area of the trapezoid is {0}", area);
    }
}

