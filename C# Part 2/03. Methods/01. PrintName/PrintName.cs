using System;

class PrintName
{
    //Write a method that asks the user for his name and prints “Hello, <name>”
    //(for example, “Hello, Peter!”). Write a program to test this method.

    static void PrintUsersName()
    {
        Console.WriteLine("Please write your name!");
        string name = Console.ReadLine();

        if (CheckName(name))
        {
            Console.WriteLine("Hello, {0}!", name);
        }
        else
        {
            Console.WriteLine("You have entered incorrect name!");
        }
        
    }

    static bool CheckName(string name)
    {
        bool isString = false;
        for (int i = 0; i < name.Length; i++)
        {
            isString = Char.IsLetter(name[i]);
            if (isString == false)
            {
                break;

            }
        }
        return isString;
    }

    static void Main()
    {
        PrintUsersName();
    }
}


