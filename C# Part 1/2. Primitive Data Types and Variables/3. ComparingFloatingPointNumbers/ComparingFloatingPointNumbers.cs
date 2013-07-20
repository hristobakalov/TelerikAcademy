using System;

class ComparingFloatingPointNumbers
{
    static void Main()
    {
        //Write a program that safely compares floating-point numbers with precision of 0.000001.
        //Examples:(5.3 ; 6.01)  false;  (5.00000001 ; 5.00000003)  true

        Console.WriteLine("Please write down the first number:");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.WriteLine("Please write down the second number:");
        double secondNumber = double.Parse(Console.ReadLine());
        if (firstNumber > secondNumber)
        {
            Console.WriteLine("The first number - {0} is bigger than the second number - {1}", firstNumber, secondNumber);
        }
        else
        {
            Console.WriteLine("The second number - {0} is bigger than the first number - {1}", secondNumber, firstNumber);
        }
    }
}

