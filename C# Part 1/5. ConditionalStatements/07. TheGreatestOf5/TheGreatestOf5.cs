using System;

class TheGreatestOf5
{
    static void Main()
    {
        //Write a program that finds the greatest of given 5 variables.

        Console.Write("Insert the first number: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Insert the second number: ");
        int secondNumber = int.Parse(Console.ReadLine());
        Console.Write("Insert the third number: ");
        int thirdNumber = int.Parse(Console.ReadLine());
        Console.Write("Insert the forth number: ");
        int forthNumber = int.Parse(Console.ReadLine());
        Console.Write("Insert the fifth number: ");
        int fifthNumber = int.Parse(Console.ReadLine());
      
        int mask1 = Math.Max(firstNumber,secondNumber);
        int mask2 = Math.Max(mask1, thirdNumber);
        int mask3 = Math.Max(mask2, forthNumber);
        int mask4 = Math.Max(mask3, fifthNumber);

        Console.WriteLine("The greatest number is: {0}", mask4);
    }
}

