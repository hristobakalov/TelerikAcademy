using System;
using System.Text;

//Write a program that reads a string from the console and replaces all series of consecutive identical letters
//with a single one. Example: "aaaaabbbbbcdddeeeedssaa"  "abcdedsa".

class ReplaceConsecutiveLetters
{
    static void Main()
    {
        string input = Console.ReadLine();
        StringBuilder sb = new StringBuilder();
        sb.Append(input[0]);
        for (int i = 1; i < input.Length; i++)
        {
            if (input[i] != input[i-1])
            {
                sb.Append(input[i]);
            }
        }
        Console.WriteLine("Removed consecutive identical letters: {0}", sb);
    }
}

