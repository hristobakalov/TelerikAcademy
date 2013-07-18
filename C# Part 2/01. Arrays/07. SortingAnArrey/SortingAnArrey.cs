using System;

class SortingAnArrey
{
    static void Main()
    {
        //Sorting an array means to arrange its elements in increasing order. Write a program to sort an array. 

        int[] array = { 0, 30, -100, 2424, 323, 253252355, -21321323, 2353256, 2323, 3 };
        Console.WriteLine("The original array is:");

        //print the array
        foreach (int element in array)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
        Console.WriteLine();

        Array.Sort(array); //using Array.Sort to sort the array
        Console.WriteLine("The sorted arrays is:");
        //print the sorted array
        foreach (int number in array)
        {
            Console.Write(number + " ");
        }
    }
}

