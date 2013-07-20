using System;
//Write a program that generates and prints to the console 10 random values in the range [100, 200].

class RandomValues
{
    static Random randomNum = new Random();

    static void Main()
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine("[{0}] {1}", i, randomNum.Next(100,200));
        }
    }
}

