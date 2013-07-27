using System;

class PointInCircle
{
    static void Main()
    //Write an expression that checks if given positive integer number n (n ≤ 100) is prime. E.g. 37 is prime.

    {
        Console.WriteLine("Please insert a number between 1 and 100!");
        int n = int.Parse(Console.ReadLine());
        int pointer = 0;
        for (int i = 2; i < n; i++)
        {
            if (n % i == 0)
            {
                pointer++;
            }
        }
        if (pointer == 0)
        {
            Console.WriteLine("{0} is a prime number!", n);
        }
        else
        {
            Console.WriteLine("{0} isn't a prime number", n);
        }
    }
}

