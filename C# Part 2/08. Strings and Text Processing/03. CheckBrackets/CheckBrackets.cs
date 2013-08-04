using System;
using System.Collections.Generic;

//Write a program to check if in a given expression the brackets are put correctly.
//Example of correct expression: ((a+b)/5-d).
//Example of incorrect expression: )(a+b)).

class CheckBrackets
{
    static void Main()
    {
        Console.WriteLine("Insert expression:");
        string input = Console.ReadLine();
        Stack<char> brackets = new Stack<char>();

        brackets.Push('(');

        
        while (brackets.Count != 0)
        {
            brackets.Pop();
            foreach (var element in input)
            {
                if (element == '(')
                {
                    brackets.Push(element);
                }
                else if (element == ')')
                {
                    if (brackets.Count == 0)
                    {
                        Console.WriteLine("Incorrect expression!");
                        return;
                    }
                    brackets.Pop();
                }
            }
        }
        if (brackets.Count == 0)
        {
            Console.WriteLine("Correct expression!");
        }
        
    }
}

