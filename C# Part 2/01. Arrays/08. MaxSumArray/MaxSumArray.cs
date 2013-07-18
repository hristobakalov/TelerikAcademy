using System;
using System.Collections.Generic;

class MaxSumArray
{
    static void Main()
    {
        //Write a program that finds the sequence of maximal sum in given array. Example:
	    //{2, 3, -6, -1, 2, -1, 6, 4, -8, 8}  {2, -1, 6, 4}
	    //Can you do it with only one loop (with single scan through the elements of the array)?

        int[] array = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };

        //print the array
        foreach (int item in array)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine("\n");

        
        int middleMax = array[0];
        int max = array[0];
        int beginPosition = 0;
        int middleBegin = 0;
        int endPosition = 0;

        for (int i = 1; i < array.Length; i++)
        {
            // calculate max ending here
            if (max < 0)
            {
                max = array[i];

                middleBegin = i;
            }
            else
            {
                max += array[i];
            }

            // calculate middleMax
            if (max >= middleMax)
            {
                middleMax = max;

                beginPosition = middleBegin;
                endPosition = i;
            }
        }
        //print the nums which have max sum
        Console.Write("The numbers with maximal sum: ");
        for (int j = beginPosition; j < endPosition - 1; j++)
        {
            Console.Write(array[j] + " ");
        }
        Console.WriteLine();
    }
}

