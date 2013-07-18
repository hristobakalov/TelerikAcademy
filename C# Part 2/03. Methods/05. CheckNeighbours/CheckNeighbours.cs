using System;

class CheckNeighbours
{
    //Write a method that checks if the element at given position in given array of integers
    //is bigger than its two neighbors (when such exist).

    static void CheckElementsNeighbours(int[] arr, int index)
    {
        if (index == 0)
        {
            if (arr[index] > arr[index + 1])
            {
                Console.WriteLine("Your number {0} is bigger than its neighbour {1}!", arr[index], arr[index + 1]);
            }
            else
            {
                Console.WriteLine("Your number {0} is smaller than its neighbour {1}!", arr[index], arr[index + 1]);
            }
        }
        else if (index == arr.Length - 1)
        {
            if (arr[index] > arr[index - 1])
            {
                Console.WriteLine("Your number {0} is bigger than its neighbour {1}!", arr[index], arr[index - 1]);
            }
            else
            {
                Console.WriteLine("Your number {0} is smaller than its neighbour {1}!", arr[index], arr[index - 1]);
            }
        }
        else if (index > 0 && index < arr.Length - 1)
        {
            if ((arr[index] > arr[index - 1]) && (arr[index] > arr[index + 1]))
            {
                Console.WriteLine("Your number {0} is bigger than its neighbours {1} and {2}!", arr[index], arr[index - 1], arr[index + 1]);
            }
            else
            {
                Console.WriteLine("Your number {0} is smaller than its neighbour {1} or {2}!", arr[index], arr[index - 1], arr[index + 1]);
            }
        }
        else
        {
            Console.WriteLine("The index should be between 0 and {0}!", arr.Length-1);
        }
    }

    static void Main()
    {
        int[] arr = { 1323, 2424, 53, 5654, 231, 12, 2434, 456666 };
        Console.WriteLine("{0}", string.Join(", ", arr));
        Console.Write("index = ");
        int index = int.Parse(Console.ReadLine());
        CheckElementsNeighbours(arr, index);
    }
}

