using System;

class PrintPermutations
{
    //* Write a program that reads a number N and generates and prints all the permutations of the numbers [1 … N]. 
    //Example: n = 3  {1, 2, 3}, {1, 3, 2}, {2, 1, 3}, {2, 3, 1}, {3, 1, 2}, {3, 2, 1}

    static void Switch(ref int first, ref int second)
    {
        int temp = first;
        first = second;
        second = temp;
    }

    static int counter = 1;

    static void Permutation(int[] array, int current, int length)
    {
        if (current == length)
        {

            Console.WriteLine("[{0}]  {1}", counter, string.Join(", ", array));
            counter++;
        }
        else
        {
            for (int i = current; i <= length; i++)
            {
                Switch(ref array[i], ref array[current]);
                Permutation(array, current + 1, length);
                Switch(ref array[i], ref array[current]);
            }
        }
    }

    static void Main(string[] args)
    {
        Console.Write("N = ");
        int n = int.Parse(Console.ReadLine());
        int[] arrayOfNumbers = new int[n];

        for (int i = 0; i < n; i++)
        {
            arrayOfNumbers[i] = i + 1;
        }
        Console.WriteLine("All permutations from 1 to {0} are:", n);
        Permutation(arrayOfNumbers, 0, arrayOfNumbers.Length - 1);
    }
}