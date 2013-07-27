using System;

class SignOfThreeNumbers
{
    static void Main()
    {
        //Write a program that shows the sign (+ or -) of the product of three real numbers without calculating it.
        //Use a sequence of if statements

        Console.Write("Insert the first number: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Insert the second number: ");
        int secondNumber = int.Parse(Console.ReadLine());
        Console.Write("Insert the third number: ");
        int thirdNumber = int.Parse(Console.ReadLine());

        if (firstNumber > 0 && secondNumber > 0 && thirdNumber > 0)
        {
            Console.WriteLine("The sign of the product is +");
        }
        else if (firstNumber < 0 && secondNumber > 0 && thirdNumber > 0)
        {
            Console.WriteLine("The sign of the product is -");
        }
        else if (firstNumber < 0 && secondNumber < 0 && thirdNumber > 0)
        {
            Console.WriteLine("The sign of the product is +");
        }
        else if (firstNumber > 0 && secondNumber < 0 && thirdNumber > 0)
        {
            Console.WriteLine("The sign of the product is -");
        }
        else if (firstNumber > 0 && secondNumber < 0 && thirdNumber < 0)
        {
            Console.WriteLine("The sign of the product is +");
        }
        else if (firstNumber > 0 && secondNumber > 0 && thirdNumber < 0)
        {
            Console.WriteLine("The sign of the product is -");
        }
        else if (firstNumber < 0 && secondNumber > 0 && thirdNumber < 0)
        {
            Console.WriteLine("The sign of the product is +");
        }
        else if (firstNumber < 0 && secondNumber < 0 && thirdNumber < 0)
        {
            Console.WriteLine("The sign of the product is -");
        }
        else
        {
            Console.WriteLine("One or more of the numbers is 0");
        }
    }
}

