using System;

class OddNumber
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        long[] arr = new long[n];
        for (int i = 0; i < n; i++)
        {
            long number = long.Parse(Console.ReadLine());

            arr[i] = number;
        }
        long oddNumber = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            oddNumber ^= arr[i];
        }
        Console.WriteLine(oddNumber);
    }
}

