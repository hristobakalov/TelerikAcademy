using System;

class ExchangingValues
{
    static void Main()
    {
        //Write an if statement that examines two integer variables
        //and exchanges their values if the first one is greater than the second one.

        Console.Write("Insert the first number: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Insert the second number: ");
        int secondNumber = int.Parse(Console.ReadLine());
        int middleNumber = firstNumber;
        if (firstNumber > secondNumber)
        {
            firstNumber = secondNumber;
            secondNumber = middleNumber;
            Console.WriteLine("The new values of the numbers are:\nFirst number = {0}\nSecond number = {1}", firstNumber, secondNumber);
        }
        else
        {
            Console.WriteLine("The second number is greater so nothing special happens here.");
        }
    }
}

