using System;
using System.Collections.Generic;

class LastDigitToWord
{
    //Write a method that returns the last digit of given integer as an English word.
    //Examples: 512  "two", 1024  "four", 12309  "nine".

    static string DigitToWord(int number)
    {
        if (number < 0)
        {
            number *= -1;
        }
        int lastDigit = number % 10;
        switch (lastDigit)
        {
            case 0:
                return "Zero";
            case 1:
                return "One";
            case 2:
                return "Two";
            case 3:
                return "Three";
            case 4:
                return "Four";
            case 5:
                return "Five";
            case 6:
                return "Six";
            case 7:
                return "Seven";
            case 8:
                return "Eight";
            case 9:
                return "Nine";
            default:
                return "You haven't entered a correct number!";
        }
    }

    static void Main()
    {
        Console.WriteLine("Please insert a number!");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("The last digit of your number is: {0}", DigitToWord(number)); 
        
    }
}

