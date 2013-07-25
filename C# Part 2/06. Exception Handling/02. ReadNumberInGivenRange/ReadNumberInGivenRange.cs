using System;

//Write a method ReadNumber(int start, int end) that enters an integer number in given range [start…end].
//If an invalid number or non-number text is entered, the method should throw an exception.
//Using this method write a program that enters 10 numbers:
//a1, a2, … a10, such that 1 < a1 < … < a10 < 100

class ReadNumberInGivenRange
{
    static int counter = 0;

    static void ReadNumber(int start, int end)
    {
        counter++;
        try
        {
            Console.Write("Insert a number in the range ({0}, {1}): ", start, end);
            string inputStr = Console.ReadLine();
            int number = int.Parse(inputStr);
            if (number <= start || number >= end)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (counter <= 10)
            {
                ReadNumber(number, end);
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("You have entered invalid number!");
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Your number is out of range!");
        }
    }

    static void Main()
    {
        ReadNumber(1, 100);
    }
}

