using System;
using System.Diagnostics;

class MostFrequentNumber
{
    static void Main()
    {
        //Write a program that finds the most frequent number in an array. Example:
	    //{4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3}  4 (5 times)

        int[] array = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 1, 1, 1, 9, 3, 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4};
        Console.WriteLine("{0}", string.Join(", ", array)); //print the array

        Console.WriteLine();

        int maxSequence = 1;
        int tempSequence = 1;
        int placeholder = int.MinValue;
        
        //main logic:
        //get one element and compare it to the rest of the array, if it equals an element, to tempSequence is added 1. 
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == placeholder)
            {
                continue; //works a little bit faster than if it is not written
            }
            for (int j = 1; j < array.Length; j++)
            {
                if (array[i] ==  array[j])
                {
                    tempSequence++;
                }
            }
            if (maxSequence < tempSequence)
            {
                maxSequence = tempSequence;
                placeholder = i;
                
            }
            tempSequence = 0;
        }
        Console.WriteLine("Number {0} is repeated {1} times in the array!", array[placeholder], maxSequence);
    }
}

