using System;

class NthCatalanNumber
{
    static void Main()
    {
        // Write a program to calculate the Nth Catalan number by given N.

        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());

        int middleProduct = 1;
        decimal product = 1;
        int nPlusOne = n + 1;

        for (int i = 2 * n; i > nPlusOne; i--)
        {
            middleProduct *= i; // In this way I calculate  (2n)! / (n + 1)!
        }
        product *= middleProduct;

        for (int i = 1; i <= n; i++)
        {
            product /= i; // Here I devide (2n)! / (n + 1)! with n!
        }

        Console.WriteLine("(2n)! / (n + 1)! * n! = {0}", product);
    }
}

