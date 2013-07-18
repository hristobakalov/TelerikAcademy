using System;

class IntDoubleOrString
{
    static void Main()
    {
        //Write a program that, depending on the user's choice inputs int, double or string variable.
        //If the variable is integer or double, increases it with 1. If the variable is string, appends "*" at its end. 
        //The program must show the value of that variable as a console output. Use switch statement.

        Console.WriteLine("Please write down if you want to insert an integer, double or string!");
        string input = Console.ReadLine();

        switch (input)
        {
            case "double":
                Console.WriteLine("You can now insert a double number");
                double doubleInput = double.Parse(Console.ReadLine());
                doubleInput++;
                Console.WriteLine("Your double number plus 1 is: {0}", doubleInput);
                break;
            case "integer":
                Console.WriteLine("You can now insert an integer number");
                int intInput = int.Parse(Console.ReadLine());
                intInput++;
                Console.WriteLine("Your integer number plus 1 is: {0}", intInput);
                break;
            case "string":
                Console.WriteLine("You can now insert a string");
                string stringInput = Console.ReadLine();
                stringInput = stringInput + "*";
                Console.WriteLine("Your string with added * at the ends looks like: {0}", stringInput);
                break;
            default:
                Console.WriteLine("You have made a mistake. You can try again!");
                break;
        }
    }
}

