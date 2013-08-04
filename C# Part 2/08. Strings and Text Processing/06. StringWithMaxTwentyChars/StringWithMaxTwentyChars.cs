using System;
using System.Text;

//Write a program that reads from the console a string of maximum 20 characters.
//If the length of the string is less than 20, the rest of the characters should be filled with '*'. 
//Print the result string into the console.

class StringWithMaxTwentyChars
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder();
        Console.Write("Write something:");
        string input = Console.ReadLine();
        sb.Append(input);
        if (sb.Length > 20)
        {
            Console.WriteLine("The length should be no more than 20 characters!");
            return;
        }
        else if (sb.Length == 20)
        {
            Console.WriteLine("Your input has exactly 20 chars!");
            Console.WriteLine(sb);
        }
        else
        {
            Console.WriteLine("Your input has less than 20 chars, so it is filled with '*' until it reaches 20 chars!");
            sb.Append(new string('*', 20 - sb.Length));
            Console.WriteLine(sb);
        }
    }
}

