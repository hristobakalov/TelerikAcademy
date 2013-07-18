using System;

class FindingMaxSum
{
    static void Main()
    {
        //Write a program that reads two integer numbers N and K and an array of N elements from the console.
        //Find in the array those K elements that have maximal sum.
        Console.Write("N = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("K = ");
        int k = int.Parse(Console.ReadLine());

        int[] array = new int[n];

        //read the array
        for (int i = 0; i < n; i++)
        {
            int input = int.Parse(Console.ReadLine());
            array[i] = input;
        }
        Console.WriteLine();

        int sum = 0;

        Array.Sort(array);
        Console.WriteLine("The array is sorted from smallest to biggest!");
        Console.WriteLine();
        //print the sorted array
        foreach (int item in array)
        {
            Console.Write(item + " ");
            
        }
        Console.WriteLine();

        int index = array.Length -1;

        //sum those K elements
        for (int i = 0; i < k; i++)
        {
            sum += array[index];
            index--;
        }
        Console.WriteLine();
        Console.WriteLine("The biggest {0} numbers have sum {1}", k, sum);
    }
}

