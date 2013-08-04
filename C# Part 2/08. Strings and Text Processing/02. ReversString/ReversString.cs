using System;

//Write a program that reads a string, reverses it and prints the result at the console.
//Example: "sample"  "elpmas".

class ReversString
{
    static void Main()
    {
        Console.WriteLine("Enter a word!");
        string sentence = Console.ReadLine();
        char[] reversed = sentence.ToCharArray();
        Array.Reverse(reversed);
        reversed.ToString();
        Console.WriteLine(reversed);
    }
}

