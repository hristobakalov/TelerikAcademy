using System;
using System.Collections.Generic;

class MaximalElement
{
    //Write a method that returns the maximal element in a portion of array of integers starting at given index.
    //Using it write another method that sorts an array in ascending / descending order.

    static int MaxElement(int[] arr, int index)
    {
        int maxNum = index;
        for (int i = index; i < arr.Length; i++)
        {
            if (arr[i] > arr[maxNum])
            {
                maxNum = i;
            }
        }
        return maxNum;
    }

    static void SortingInDescendingOrder(int[] arr)
    {
        List<int> sortedArray = new List<int>();
        for (int i = 0; i < arr.Length; i++)
        {
            sortedArray.Add(arr[MaxElement(arr, 0)]);
            arr[MaxElement(arr, 0)] = int.MinValue;
        }
        Console.WriteLine("The array sorted in descending order: {0}", string.Join(", ", sortedArray));
        
    }

    static void Main()
    {
        int[] array = { 50, 6, 8, 1, 11, 23, 3, 7 };
        Console.WriteLine("{0}", string.Join(", ", array));
        Console.Write("Choose from 0 to {0} index = ", array.Length - 1);
        int index = int.Parse(Console.ReadLine());
        Console.WriteLine("The biggest number in the given range is: {0}", array[MaxElement(array, index)]);

        SortingInDescendingOrder(array);


    }
}

