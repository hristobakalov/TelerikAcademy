using System;

class BiggestInteger
{
    static void Main()
    {
        //Write a program that finds the biggest of three integers using nested if statements.

        Console.Write("Insert the first number: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Insert the second number: ");
        int secondNumber = int.Parse(Console.ReadLine());
        Console.Write("Insert the third number: ");
        int thirdNumber = int.Parse(Console.ReadLine());
        if (firstNumber > secondNumber && firstNumber > thirdNumber)
        {
            Console.WriteLine("The biggest number is: {0}", firstNumber);
        }
        else
        {
            if (secondNumber > firstNumber && secondNumber > thirdNumber)
            {
                Console.WriteLine("The biggest number is: {0}", secondNumber);
            }
            else
            {
                if (thirdNumber > firstNumber && thirdNumber > secondNumber)
                {
                    Console.WriteLine("The biggest number is: {0}", thirdNumber);
                }
                else
                {
                    Console.WriteLine("The three numbers are equal!!!");
                }
            }
        }
    }
}

