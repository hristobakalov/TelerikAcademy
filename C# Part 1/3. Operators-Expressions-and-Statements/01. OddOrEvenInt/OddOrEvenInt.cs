using System;

class OddOrEvenInt
{
    static void Main()
    //Write an expression that checks if given integer is odd or even.

    {
        Console.WriteLine("Please write down a number");
        int a = int.Parse(Console.ReadLine());
        bool result = a % 2 == 0;
        Console.WriteLine(result);
    }
}