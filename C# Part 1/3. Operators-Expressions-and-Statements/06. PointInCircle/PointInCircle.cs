using System;

class PointInCircle
{
    static void Main()
    //Write an expression that checks if given point (x,  y) is within a circle K(O, 5).

    {
        Console.WriteLine("Please insert point X!");
        int x = int.Parse(Console.ReadLine());
        Console.WriteLine("Please insert point Y!");
        int y = int.Parse(Console.ReadLine());
        double sum = ((x * x) + (y * y));
        int k = 5;
        int kpow = k * k;
        bool withinCircle = sum < kpow;
        Console.WriteLine(withinCircle);
    }
}

