using System;

class PrintCombinations
{
    
    //Write a program that reads two numbers N and K and generates all the combinations of K distinct elements from the set [1..N]. 
    //Example: N = 5, K = 2  {1, 2}, {1, 3}, {1, 4}, {1, 5}, {2, 3}, {2, 4}, {2, 5}, {3, 4}, {3, 5}, {4, 5}

    static int n = int.Parse(Console.ReadLine());
    static int k = int.Parse(Console.ReadLine());
    static int counter = 1;
    static void PrintArray(int[] array)
    {

        Console.WriteLine("[{0}] {1}", counter, string.Join(", ", array));
        counter++;

    }

    static void Combinations(int[] array, int startIndex, int startNumber)
    {
        if (startIndex == array.Length)
        {
            PrintArray(array);
        }
        else
        {
            for (int i = startNumber; i <= n; i++)
            {
                array[startIndex] = i;
                Combinations(array, startIndex + 1, i + 1);
            }
        }
    }

    static void Main()
    {
        int[] arr = new int[k];
        Combinations(arr, 0, 1);
    }
}

