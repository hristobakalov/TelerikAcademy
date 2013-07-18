using System;

class PerimeterAndAreaOfCircle
{
    static void Main()
    {
        //Write a program that reads the radius r of a circle and prints its perimeter and area.
        Console.Write("Please insert the radius of the circle - ");
        double radius = double.Parse(Console.ReadLine()); // Reads the number that you have entered and converts it from string to double
        double perimeter = 2 * radius * Math.PI; // calculates the perimeter, Math.PI is a function from the Math library of C#
        double area = radius * radius * Math.PI; // calculates the area of the circle
        Console.WriteLine("The perimeter of the circle is : {0}\nThe are of the circle is : {1}", perimeter, area);
    }
}
