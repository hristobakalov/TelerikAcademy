using System;

class SortingInDescendingOrder
{
    static void Main()
    {
        //Sort 3 real values in descending order using nested if statements.

        Console.Write("Insert the first number: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Insert the second number: ");
        int secondNumber = int.Parse(Console.ReadLine());
        Console.Write("Insert the third number: ");
        int thirdNumber = int.Parse(Console.ReadLine());

        if (firstNumber > secondNumber && firstNumber > thirdNumber)
        {
            if (secondNumber > thirdNumber)
            {
                Console.WriteLine("The numbers in descending order are: {0}, {1}, {2}", firstNumber, secondNumber, thirdNumber);
            }
            else
            {
                Console.WriteLine("The numbers in descending order are: {0}, {1}, {2}", firstNumber, thirdNumber, secondNumber);
            }
            
        }
        else
        {
            if (secondNumber > firstNumber && secondNumber > thirdNumber)
            {
                if (firstNumber > thirdNumber)
                {
                    Console.WriteLine("The numbers in descending order are: {0}, {1}, {2}", secondNumber, firstNumber, thirdNumber);
                }
                else
                {
                    Console.WriteLine("The numbers in descending order are: {0}, {1}, {2}", secondNumber, thirdNumber, firstNumber);
                }
                
            }
            else
            {
                if (thirdNumber > firstNumber && thirdNumber > secondNumber)
                {
                    if (firstNumber > secondNumber)
                    {
                        Console.WriteLine("The numbers in descending order are: {0}, {1}, {2}", thirdNumber, firstNumber, secondNumber);
                    }
                    else
                    {
                        Console.WriteLine("The numbers in descending order are: {0}, {1}, {2}", thirdNumber, secondNumber, firstNumber);
                    }
                }
                else
                {
                    Console.WriteLine("The three numbers are equal so it's impossible to arrange them in descending order!");
                }
            }
        }
    }
}

