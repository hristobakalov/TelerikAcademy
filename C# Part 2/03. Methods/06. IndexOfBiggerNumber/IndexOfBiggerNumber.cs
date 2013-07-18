using System;

class IndexOfBiggerNumber
{
    //Write a method that returns the index of the first element in array that is bigger than its neighbors,
    //or -1, if there’s no such element. Use the method from the previous exercise.

    static void CheckElementsNeighbours(int[] arr, int index)
    {
        if (index == 0)
        {
            if (arr[index] > arr[index + 1])
            {
                Console.WriteLine(arr[index]);
                return;

            }
        }
        else if (index == arr.Length - 1)
        {
            if (arr[index] > arr[index - 1])
            {
                Console.WriteLine(arr[index]);
                return;
            }
        }
        else if (index > 0 && index < arr.Length - 1)
        {
            if ((arr[index] > arr[index - 1]) && (arr[index] > arr[index + 1]))
            {
                Console.WriteLine(arr[index]);
                return;
            }
        }
        else
        {
            Console.WriteLine("There isn't such a number (-1)");
            return;
        }
        CheckElementsNeighbours(arr, index + 1);
    }

    static void Main()
    {
        int[] array = { 1, 3, 5, 6, 70, 800, 800};
        Console.WriteLine("{0}", string.Join(", ", array));
        Console.Write("The first number that is bigger than its neighbours is: "); 
        CheckElementsNeighbours(array, 0);
    }
}

