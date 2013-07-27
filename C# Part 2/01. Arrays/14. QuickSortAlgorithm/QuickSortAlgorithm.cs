using System;

class QuickSortAlgorithm
{
    //Write a program that sorts an array of strings using the quick sort algorithm (find it in Wikipedia).

    static void QuickSort(int[] arr, int left, int right)
    {
        if (left >= right) // checks if the array is with only one element or is empty
        {
            return;
        }
       
        int i = left;
        int j = right;
        int p = arr[right];

        while (i < j)
        {
            while (i < j && arr[i] <= p)
            {
                i++;
            }

            while (i < j && arr[j] >= p)
            {
                j--;
            }
            if (i < j)
            {
                int t = arr[i];
                arr[i] = arr[j];
                arr[j] = t;
            }
        }
        int k = arr[i];
        arr[i] = arr[right];
        arr[right] = k;

        QuickSort(arr, left, i - 1); //using recursion
        QuickSort(arr, i + 1, right);
    }

    static void Main()
    {
        int[] arr = { 6, 9, 5, 3, 11, 7, 10, 2, 8, 1004, 6 };

        Console.WriteLine("Array before it's sorted:\n{0}", String.Join(", ", arr));
             
        QuickSort(arr, 0 , arr.Length - 1);

        Console.WriteLine("Array after it's sorted:\n{0}", String.Join(", ", arr));
    }
}

