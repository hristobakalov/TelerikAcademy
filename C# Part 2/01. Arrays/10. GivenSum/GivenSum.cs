using System;
using System.Collections.Generic;

class GivenSum
{
    static void Main()
    {
        //Write a program that finds in given array of integers a sequence of given sum S (if present).
        //Example:	 {4, 3, 1, 4, 2, 5, 8}, S=11  {4, 2, 5}

        Console.Write("sum = ");
        int sum = int.Parse(Console.ReadLine());
        Console.WriteLine();
        int[] array = { 4, 3, 1, 4, 2, 5, 8 };
        //print the array
        foreach (int item in array)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine("\n");

        List<int> finalNumber = new List<int>();
        int tempSum = 0;
        
        for (int i = 0; i < array.Length-1; i++)
        {
            tempSum += array[i];
            finalNumber.Add(array[i]);
            if (tempSum > sum)
            {
                tempSum = 0;
                i--;
                finalNumber.Clear();
            }
            if (tempSum == sum)
            {
                break;
            }
        }
        if (tempSum != sum)
        {
            Console.WriteLine("There isn't such sum!");
            return;
        }
        Console.Write("The numbers which have sum {0} are: ", sum);
        foreach (int item in finalNumber)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}

