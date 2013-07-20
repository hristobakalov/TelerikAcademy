using System;

class ReadAndSum
{
    static void Main()
    {
        //Write a program that reads 3 integer numbers from the console and prints their sum.
        Console.Write("Please insert the first number - ");
        int firstNumber = int.Parse(Console.ReadLine()); // Reads the number that you have entered and converts it from string to integer
        Console.Write("Please insert the second number - ");
        int secondNumber = int.Parse(Console.ReadLine()); // Reads the number that you have entered and converts it from string to integer
        Console.Write("Please insert the third number - ");
        int thirdNumber = int.Parse(Console.ReadLine()); // Reads the number that you have entered and converts it from string to integer
        Console.WriteLine("The sum of the three numbers that you entered is: {0}", (firstNumber + secondNumber + thirdNumber)); // sums the three numbers and prints the results
    }
}

