using System;

class PrintVariations
{
    //Write a program that reads two numbers N and K and generates all the variations of K elements from the set [1..N]. 
    //Example: N = 3, K = 2  {1, 1}, {1, 2}, {1, 3}, {2, 1}, {2, 2}, {2, 3}, {3, 1}, {3, 2}, {3, 3}

    static int n = int.Parse(Console.ReadLine());
    static int k = int.Parse(Console.ReadLine());
    static int counter = 1;
    static void PrintArray(int[] array)
    {

        Console.WriteLine("[{0}] {1}", counter, string.Join(", ", array));
        counter++;

    }

    static void Variations(int[] array, int startIndex, int startNumber)
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
                Variations(array, startIndex + 1, i);
            }
        }
    }

    static void Main()
    {
        int[] arr = new int[k];
        Variations(arr, 0, 1);
    }
}

