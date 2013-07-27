using System;

class QuadraticEquation
{
    static void Main()
    {
        //Write a program that reads the coefficients a, b and c of a quadratic equation ax2+bx+c=0 and solves it (prints its real roots).
        Console.Write("Insert the coefficient a - ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Insert the coefficient b - ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Insert the coefficient c - ");
        int c = int.Parse(Console.ReadLine());
        Console.WriteLine("Your quadratic equation looks like ({0}x^2) +({1}x) + ({2}) = 0", a, b, c);
        double discriminant = (b * b) - (4 * a * c);
        if (discriminant >= 0)
        {
            double firstRoot = ((-b) + Math.Sqrt(discriminant)) / (2 * a);
            double secondRoot = ((-b) - Math.Sqrt(discriminant)) / (2 * a);
            Console.WriteLine("The first root of the equation is : {0}, the second one is : {1}", firstRoot, secondRoot);
        }
        else
	    {
            Console.WriteLine("The roots aren't real!");
	    }
    }
}
