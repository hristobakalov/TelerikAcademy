using System;

class ExchangingValues
{
    static void Main()
    {
        //Declare  two integer variables and assign them with 5 and 10 and after that exchange their values.

        int a = 5;
        int b = 10;
        int middleVariable = b;
        b = a;
        a = middleVariable;
        Console.WriteLine("Before exchanging a = 5 & b = 10\nAfter exchanging a = {0} & b = {1}", a, b);
    }
}

