using System;
using System.Collections.Generic;

class SubsetSumOfKElements
{
    //* Write a program that reads three integer numbers N, K and S and an array of N elements from the console.
    //Find in the array a subset of K elements that have sum S or indicate about its absence.

    static void Main()
    {
        Console.Write("K elements = ");
        int k = int.Parse(Console.ReadLine());
        Console.Write("Sum = ");
        long s = long.Parse(Console.ReadLine());
        Console.Write("Amount of numbers = ");
        int n = int.Parse(Console.ReadLine());

        long[] numbers = new long[n];

        List<long> numbersWithSumS = new List<long>();

        bool subsetSumFound = false;

        for (int i = 0; i < n; i++)
        {
            numbers[i] = long.Parse(Console.ReadLine());
        }
        Console.WriteLine("\nNumbers with sum {0} and {1} elements found:\n", s, k);

        int combinations = (int)Math.Pow(2, n);

        // the same code as the one from the previous problem,
        // with the difference, that here the count of the numbers is checked if equals the number of the elements 
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
            if ((tempSum == s) && (numbersWithSumS.Count == k)) 
            {
                Console.WriteLine("{0}", string.Join(", ", numbersWithSumS));
                subsetSumFound = true;

            }
            numbersWithSumS.Clear();
        }

        if (subsetSumFound == false)
        {
            Console.WriteLine("There aren't numbers with such sum and such number of elements!");
        }
    }
}

