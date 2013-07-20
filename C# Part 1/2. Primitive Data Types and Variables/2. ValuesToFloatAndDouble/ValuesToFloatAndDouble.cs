using System;

class ValuesToFloatAndDouble
{
    static void Main()
    {
        //Which of the following values can be assigned to a variable of type float and
        //which to a variable of type double: 34.567839023, 12.345, 8923.1234857, 3456.091?

        float a = 12.345F;
        float b = 3456.091F;
        double c = 34.567839023;
        double d = 8923.1234857;
        Console.WriteLine("float a = {0}, float b = {1}\ndouble c = {2}, double d = {3}", a, b, c, d);
    }
}

