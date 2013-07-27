using System;

class NumberToEnglishPronunciation
{
    static void Main()
    {
        //Write a program that converts a number in the range [0...999] to a text corresponding to its English pronunciation.

        Console.WriteLine("Insert a number between 0 and 999");
        int input = int.Parse(Console.ReadLine());
        int desimals = 0;
        int hundreds = 0;
        string[] unit = new string[10]{"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
        string[] desimal = new string[10] { "", "", "twenty ", "thrirty ", "fourty ", "fifty ", "sixty ", "seventy ", "eighty ", "ninety " };
        string[] desimal1 = new string[11] { "", "ten", "eleven", "twelve", "thirteen", "fourteen",
                                            "fifteen", "sixteen", "seventeen", "eighteen", "ninteen" };
        string number = "";
        if (input >= 100)
        {
            hundreds = input / 100;
            input = input - (100 * hundreds);
            number = unit[hundreds] + " hundred" + " ";
        }
        if (input >= 20)
        {
            desimals = input / 10;
            input = input - (10 * desimals);
            number += desimal[desimals];
        }
        else if (input >= 10)
        {
            number += desimal1[input - 9];
            input = 0;
        }
        if (input >= 0)
        {
            desimals = input;
            number += unit[desimals];
        }
        else
        {
            Console.WriteLine("Your number isn't between 0 and 999. Try again!");
        }
        Console.WriteLine(number);
    }
}

