using System;

//Write a program that finds how many times a substring is contained in a given text (perform case insensitive search).

class CountSubstringContaining
{
    private static int CountOccurences(string text, string searchedNum)
    {
        int counter = 0;
        int index = text.IndexOf(searchedNum);
        while (index != -1)
        {
            counter++;
            index = text.IndexOf(searchedNum, index + 1); 
        }

        return counter;
    }

    static void Main()
    {
        string text = "We are living in an yellow submarine. We don't have anything else.\nInside the submarine is very tight. So we are drinking all the day.\nWe will move out of it in 5 days.";
        Console.WriteLine(text);
        text = text.ToLower();
        string searchedSubString = "in";
        Console.WriteLine();
        Console.WriteLine("The substring \"{0}\" appears {1} times in the text!", searchedSubString, CountOccurences(text, searchedSubString)); 
    }
}

