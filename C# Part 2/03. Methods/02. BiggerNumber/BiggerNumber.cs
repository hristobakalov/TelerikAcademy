using System;

class BiggerNumber
{
    //Write a method GetMax() with two parameters that returns the bigger of two integers.
    //Write a program that reads 3 integers from the console and prints the biggest of them using the method GetMax().

    static int GetMax( int number1, int number2)
    {
        int biggestNumber = Math.Max(number1, number2);
        return biggestNumber;
    }

    static void Main()
    {
        Console.Write("First number = ");
        int firstNum = int.Parse(Console.ReadLine());
        Console.Write("Second number = ");
        int secondNum = int.Parse(Console.ReadLine());
        Console.Write("Third number = ");
        int thirdNum = int.Parse(Console.ReadLine());

        Console.WriteLine("The biggest number is {0}", GetMax(GetMax(firstNum, secondNum), thirdNum));
    }
}

