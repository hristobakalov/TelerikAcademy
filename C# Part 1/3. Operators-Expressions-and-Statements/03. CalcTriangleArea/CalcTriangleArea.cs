using System;

class CalcTriangleArea
{
    static void Main()
    //Write an expression that calculates rectangle’s area by given width and height.

    {
        Console.WriteLine("Please right down the width of the rectangle!");
        int width = int.Parse(Console.ReadLine());
        Console.WriteLine("Please right down the 'height of the rectangle!");
        int height = int.Parse(Console.ReadLine());
        int area = (width * height);
        Console.WriteLine("The area of the rectangle is: {0}", area);
    }
}

