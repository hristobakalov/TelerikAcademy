using System;
using System.Collections.Generic;
using System.Threading;
//Write methods that calculate the surface of a triangle by given:
//Side and an altitude to it; Three sides; Two sides and an angle between them. Use System.Math.

class SurfaceOfTriangle
{
    static double SurfaceBySideAndHeight(double side, double height)
    {
        double surface = 1;
        surface = side * height / 2;
        return surface;
    }

    static double SurfaceByThreeSides(double sideFirst, double sideSecond, double sideThird)
    {
        double surface = 1;
        double sum = sideFirst + sideSecond + sideThird;

        surface = Math.Sqrt(sum * (sum - sideFirst) * (sum - sideSecond) * (sum - sideThird));
        return surface;
    }

    static double SurfaceByTwoSidesAndAngle(double sideFirst, double sideSecond, double angle)
    {
        double surface = 1;

        surface = sideFirst * sideSecond * (Math.Sin(angle)) / 2;
        return surface;
    }

    static void Main()
    {
        Console.WriteLine("Insert values just to parametars which you want to use, the others should be empty!");
        Console.WriteLine("Example: a = 5, b = 6, c = 7 | a = 5, b = 3, angle = 30");

        Console.Write("a = ");
        string aStr = Console.ReadLine();
        double a = double.Parse(aStr);


        Console.Write("b = ");
        string bStr = Console.ReadLine();
        double b = double.Parse(bStr);


        Console.Write("c = ");
        string cStr = Console.ReadLine();
        double c = double.Parse(cStr);


        Console.Write("h = ");
        string hStr = Console.ReadLine();
        double h = double.Parse(hStr);


        Console.Write("angle = ");
        string angleStr = Console.ReadLine();
        double angle = double.Parse(angleStr);


        Console.WriteLine("The surface by side a and h: {0}", SurfaceBySideAndHeight(a, h));
        Console.WriteLine("The surface by three sides: {0}", SurfaceByThreeSides(a,b,c));
        Console.WriteLine("The surface by sides a, b and angle: {0}", SurfaceByTwoSidesAndAngle(a,b,angle));
    }
}

