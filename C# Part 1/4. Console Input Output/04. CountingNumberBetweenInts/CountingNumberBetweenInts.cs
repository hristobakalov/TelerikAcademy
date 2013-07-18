using System;

class CountingNumberBetweenInts
{
    static void Main()
    {
        //Write a program that reads two positive integer numbers and prints
        //how many numbers p exist between them such that the reminder of 
        //the division by 5 is 0 (inclusive). Example: p(17,25) = 2.

        Console.Write("Please enter the smaller number here - ");
        int firsrtNum = int.Parse(Console.ReadLine());
        Console.Write("Please enter the bigger number here - ");
        int secondNum = int.Parse(Console.ReadLine());
        int p = 0;
        for (int i = firsrtNum; i <= secondNum; i++) //the cycle for goes through the numbers between your numbers  
        {
            if (i % 5 == 0) //checks if the numbers can be divided by 5 if they can, the value of p increases with 1
            {
                p++;
            }
        }
        Console.WriteLine("There are {0} numbers between {1} and {2} that can be diveded by 5!", p, firsrtNum, secondNum);
    }
}
