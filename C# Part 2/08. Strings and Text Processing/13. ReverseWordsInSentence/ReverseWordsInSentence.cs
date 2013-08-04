using System;

//Write a program that reverses the words in given sentence.
//Example: "C# is not C++, not PHP and not Delphi!"  "Delphi not and PHP, not C++ not is C#!".

class ReverseWordsInSentence
{
    static void Main()
    {
        Console.WriteLine("Insert your sentence to be reversed!");
        string input = Console.ReadLine();
        string[] words = input.Split(new char[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
        Array.Reverse(words);
        Console.WriteLine("Your sentence reversed:");
        Console.WriteLine("{0}", String.Join(" ", words));
    }
}

