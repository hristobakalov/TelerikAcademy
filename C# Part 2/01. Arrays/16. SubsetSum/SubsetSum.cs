using System;
using System.Collections.Generic;

class SubsetSum
{
    //* We are given an array of integers and a number S.
    //Write a program to find if there exists a subset of the elements of the array that has a sum S. 
    //Example: arr={2, 1, 2, 4, 3, 5, 2, 6}, S=14  yes (1+2+5+6)

    static void Main()
    {
        Console.Write("Sum = ");
        long s = long.Parse(Console.ReadLine());
        Console.Write("Amount of numbers = ");
        int n = int.Parse(Console.ReadLine());

        long[] numbers = new long[n];

        List<long> numbersWithSumS = new List<long>();

        bool subsetSumFound = false;

        //fulfill the array
        for (int i = 0; i < n; i++)
        {
            numbers[i] = long.Parse(Console.ReadLine());
        }
        Console.WriteLine("\nNumbers with sum {0} found:\n", s);

        int combinations = (int)Math.Pow(2, n);

        //goes through the number of combinations represented in binary system 
        //(for example: if i=3 (binary: 00011, so it gets the first and the second number)
        for (int i = 1; i < combinations; i++)
        {
            long tempSum = 0;
            for (int j = 0; j < n; j++)
            {
                int mask = 1 << j;
                int iAndMask = mask & i;
                int bit = iAndMask >> j;

                if (bit == 1)
                {
                    tempSum += numbers[j];
                    numbersWithSumS.Add(numbers[j]);
                }
            }

            if (tempSum == s)
            {
                Console.WriteLine("{0}", string.Join(", ", numbersWithSumS));
                subsetSumFound = true;

            }
            numbersWithSumS.Clear();
        }

        if (subsetSumFound == false)
        {
            Console.WriteLine("There aren't numbers with such sum!");
        }
    }
}

