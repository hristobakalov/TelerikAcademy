using System;

public class CountNumberInArray
{
    //Write a method that counts how many times given number appears in given array.
    //Write a test program to check if the method is working correctly.

    public static int CountNumber(int[] arr, int number)
    {
        int counter = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == number)
            {
                counter++;
            }
        }
        return counter;
    }

    public static void Main()
    {
        int[] arr = { 1, 2, 3, 25, 345345, 23, 4, 4, 6456, 4, 6, 3, 4, 4 };
        Console.WriteLine("The array is: {0}",string.Join(", ", arr));
        Console.WriteLine("Insert a number which you want to count!");
        int searchedNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Your number {0} appears {1} times in the array.", searchedNumber, CountNumber(arr, searchedNumber));


        // In the next project named CountNumberUnitTests are the tests for this method, if you want to run them
        //just right click and there you should see "Run Tests". 
    }
}

