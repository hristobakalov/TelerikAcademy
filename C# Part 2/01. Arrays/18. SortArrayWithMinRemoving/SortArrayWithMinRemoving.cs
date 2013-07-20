using System;
using System.Collections.Generic;

class SortArrayWithMinRemoving
{
    //* Write a program that reads an array of integers and removes from it a minimal number of elements
    //in such way that the remaining array is sorted in increasing order.
    //Print the remaining sorted array. Example:
    //{6, 1, 4, 3, 0, 3, 6, 4, 5}  {1, 3, 3, 4, 5}

    
    static bool CheckIfSorted(List<int> listOfInt)
    {
        //method that returns true/false, whether the list is sorted
        int counter = 0;
        for (int i = 0; i < listOfInt.Count-1; i++)
        {
            if (listOfInt[i] <= listOfInt[i + 1])
            {
                counter++;
            }
        }
        if (counter == listOfInt.Count-1)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    static void Main()
    {
        int[] arr = { 6, 1, 4, 3, 0, 3, 6, 4, 5, 8,7, 3, 9, 101 };

        Console.WriteLine("Array unsorted:\n{0}", string.Join(", ", arr));
        List<int> maxList = new List<int>();
        List<int> sortedArray = new List<int>();

        int combinations = (int)Math.Pow(2, arr.Length);

        //again using the combinations represented as a binary number to check every subset
        for (int i = combinations - 1; i > 0; i--)
        {
            for (int j = 0; j < arr.Length; j++)
            {
                int mask = 1 << j;
                int iAndMask = mask & i;
                int bit = iAndMask >> j;

                if (bit == 1)
                {
                    sortedArray.Add(arr[j]);
                }
            }

            //if the list is sorted and if it is bigger than the one before, it is saved in the maxList
            if (CheckIfSorted(sortedArray) == true)
            {
                if (sortedArray.Count > maxList.Count)
                {
                    maxList.Clear();
                    for (int k = 0; k < sortedArray.Count; k++)
                    {
                        maxList.Add(sortedArray[k]);
                    }
                }
                sortedArray.Clear();
            }
            else
            {
                sortedArray.Clear();
            }
        }
        Console.WriteLine("Array sorted:\n{0}", string.Join(", ", maxList));
    }
}

