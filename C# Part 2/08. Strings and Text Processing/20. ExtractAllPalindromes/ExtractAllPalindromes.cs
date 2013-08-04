using System;
using System.Text;

//Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".

class ExtractAllPalindromes
{
    private static bool CheckIfPalindrome(string word)
    {
        StringBuilder wordReversed = new StringBuilder();
        for (int i = word.Length - 1; i >= 0; i--)
        {
            wordReversed.Append(word[i]);
        }

        if (word == wordReversed.ToString())
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    static void Main()
    {
        Console.WriteLine("Enter text!");
        string input = Console.ReadLine();
        string[] list = input.Split(new char[] { ' ', ',', '.', '-', ':', ';' }, StringSplitOptions.RemoveEmptyEntries);
        Console.WriteLine("List of palindromes:");
        for (int i = 0; i < list.Length; i++)
        {
            if (CheckIfPalindrome(list[i]))
            {
                Console.WriteLine(list[i]);
            }
        }
    }
}

