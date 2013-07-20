using System;
using System.Collections.Generic;

class GenericMethod
{
    //* Modify your last program and try to make it work for any number type, not just integer (e.g. decimal, float, byte, etc.).
    //Use generic method (read in Internet about generic methods in C#).

    static T MinimumNumber<T>(params T[] array)
    {
        Array.Sort(array);
        return array[0];
    }

    static T MaximumNumber<T>(params T[] array)
    {
        Array.Sort(array);
        return array[array.Length - 1];
    }

    static T Sum<T>(params T[] array)
    {
        dynamic sum = 0;
        foreach (var item in array)
        {
            sum += item;
        }
        return sum;
    }

    static T Average<T>(params T[] array)
    {
        dynamic average = 0;
        foreach (var item in array)
        {
            average += item;
        }
        average /= array.Length;
        return average;
    }

    static T Product<T>(params T[] array)
    {
        dynamic product = 1;
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
        decimal[] arr = new decimal[countOfNumbers];
        for (int i = 0; i < countOfNumbers; i++)
        {
            dynamic number = Convert.ToDecimal(Console.ReadLine());
            arr[i] = number;
        }

        Console.WriteLine("The smallest number is: {0}", MinimumNumber(arr));
        Console.WriteLine("The biggest number is: {0}", MaximumNumber(arr));
        Console.WriteLine("The average value is: {0}", Average(arr));
        Console.WriteLine("The sum of the numbers is: {0}", Sum(arr));
        Console.WriteLine("The product of the numbers is: {0}", Product(arr));

    }
}