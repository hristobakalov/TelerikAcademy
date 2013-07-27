using System;

class NNumbersSumUp
{
    static void Main()
    {
        //Write a program that gets a number n and after that gets more n numbers and calculates and prints their sum. 

        Console.Write("Insert the how much numbers you want to write - ");
        int n = int.Parse(Console.ReadLine());
        double sum = 0;
        for (int i = 0; i < n; i++)
        {
           double numbers = double.Parse(Console.ReadLine());
           sum += numbers;
        }
        Console.WriteLine("The sum of the numbers is : {0}", sum);
    }
}
