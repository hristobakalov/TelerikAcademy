using System;
//You are given a sequence of positive integer values written into a string, separated by spaces.
//Write a function that reads these values from given string and calculates their sum. 
//Example: string = "43 68 9 23 318"  result = 461

class CalculateSum
{
    static void Main()
    {
        Console.WriteLine("Insert the sequence of values, separated by spaces:");
        string numbers = Console.ReadLine();

        string[] arr = numbers.Split(' ');

        int sum = 0;

        foreach (string number in arr)
        {
            sum += int.Parse(number);
        }
        Console.WriteLine("The sum of this numbers is: {0}", sum);
    }
}

