using System;

class BinarySearch
{
    static void Main()
    {
        //Write a program that finds the index of given element
        //in a sorted array of integers by using the binary search algorithm (find it in Wikipedia).

        int[] arr = { 1, 3, 4, 8, 12, 13, 33, 48, 100, 25425, 24234111 };
        //print array
        foreach (int item in arr)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine("\n");

        Console.WriteLine("Choose a number from the array given above!");
        int searchedNum = int.Parse(Console.ReadLine());

        int max = arr.Length - 1;
        int min = 0;

        bool numberAppearsInArray = false;

        //chech if the searched number exists
        for (int i = 0; i < arr.Length; i++)
        {
            if (searchedNum == arr[i])
            {
                numberAppearsInArray = true;
            }
        }
        if (!numberAppearsInArray)
        {
            Console.WriteLine("Your number doesn't appear to be in the array!");
            return;
        }

        //check if the array is empty
        if (max < min)
        {
            Console.WriteLine("The array is empty");
            return;
        }
        else
        {
            bool numberFound = false;
            while (numberFound != true) //cycling until the number is found
            {
                int middle = (max + min) / 2;
                //check in which half is the number and starts again in the half in which is the number until it is found
                if (arr[middle] > searchedNum)
                {
                    max = middle;
                    continue;
                }
                else if (arr[middle] < searchedNum)
                {
                    min = middle;
                    continue;
                }
                else if (arr[middle] == searchedNum)
                {
                    Console.WriteLine("I found it!!!!");
                    numberFound = true;
                    Console.WriteLine("Your number - {0} is placed on {1} position", searchedNum, middle);
                }
                else
                {
                    Console.WriteLine("Husten we have a problem!");
                }
            }

        }

    }
}

