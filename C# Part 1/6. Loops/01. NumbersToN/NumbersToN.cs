using System;

class NumbersToN
{
    static void Main()
    {
        //Write a program that prints all the numbers from 1 to N.

        Console.Write("N = ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(i);
        }
    }
}

