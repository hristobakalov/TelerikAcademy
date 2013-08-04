using System;

//Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.

class PrintInAlphabeticalOrder
{
    static void Main()
    {
        Console.WriteLine("Enter the list of words, separeted by spaces!");
        string input = Console.ReadLine();
        string[] list = input.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
        Array.Sort(list);
        Console.WriteLine("Words sorted: {0}", string.Join(" ", list));
    }
}

