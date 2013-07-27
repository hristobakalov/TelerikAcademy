using System;

class CalculatingSetOfIntegers
{
    //Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
    //Use variable number of arguments.

    static int MinimumNumber(int[] array)
    {
        Array.Sort(array);
        return array[0];
    }

    static int MaximumNumber(int[] array)
    {
        Array.Sort(array);
        return array[array.Length-1];
    }

    static int Sum(int[] array)
    {
        int sum = 0;
        foreach (var item in array)
        {
            sum += item;
        }
        return sum;
    }

    static double Average(int[] array)
    {
        double average = 0;
        foreach (var item in array)
        {
            average += item;
        }
        average /= array.Length;
        return average;
    }

    static int Product(int[] array)
    {
        int product = 1;
        foreach (var item in array)
        {
            product *= item;
        }
        return product;
    }

    static void Main()
    {
        Console.WriteLine("Write down how many numbers do you want to enter!");
        int countOfNumbers = int.Parse(Console.ReadLine());
        int[] arr = new int[countOfNumbers];
        for (int i = 0; i < countOfNumbers; i++)
        {
            int number = int.Parse(Console.ReadLine());
            arr[i] = number;
        }

        Console.WriteLine("The smallest number is: {0}", MinimumNumber(arr));
        Console.WriteLine("The biggest number is: {0}", MaximumNumber(arr));
        Console.WriteLine("The average value is: {0}", Average(arr));
        Console.WriteLine("The sum of the numbers is: {0}", Sum(arr));
        Console.WriteLine("The product of the numbers is: {0}", Product(arr));

    }
}

