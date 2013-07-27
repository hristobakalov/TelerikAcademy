using System;

class GreaterNumber
{
    static void Main()
    {
        //Write a program that gets two numbers from the console and prints the greater of them. Don’t use if statements.

        Console.Write("Insert the first number - ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Insert the second number - ");
        int secondNumber = int.Parse(Console.ReadLine());
        int greaterNumber = Math.Max(firstNumber, secondNumber); // Checks which number is bigger
        Console.WriteLine("The bigger number is : {0}", greaterNumber);
    }
}
