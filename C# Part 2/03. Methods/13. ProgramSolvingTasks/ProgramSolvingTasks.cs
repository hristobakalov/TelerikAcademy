using System;

class ProgramSolvingTasks
{
    //Write a program that can solve these tasks:
    //Reverses the digits of a number
    //Calculates the average of a sequence of integers
    //Solves a linear equation a * x + b = 0
		//Create appropriate methods.
		//Provide a simple text-based menu for the user to choose which task to solve.
		//Validate the input data:
    //The decimal number should be non-negative
    //The sequence should not be empty
    //a should not be equal to 0

    static void ReversNumber(decimal number)
    {
        string numberToString = number.ToString();
        string numberWithoutComa = "";
        for (int i = numberToString.Length - 1; i >= 0; i--)
        {
            if (numberToString[i] != ',')
            {
                numberWithoutComa += numberToString[i];
            }
            else
            {
                numberWithoutComa += ",";
            }
        }
        Console.WriteLine("Your number reversed: {0}", numberWithoutComa);
    }

    static void Average(int[] array)
    {
        double average = 0;
        foreach (var item in array)
        {
            average += item;
        }
        average /= array.Length;
        Console.WriteLine("The average value of the given array is: {0}", average);
    }

    static void LinearEquation(int a, int b)
    {
        double x = (b * (-1)) / a;
        Console.WriteLine("x = {0}", x);
    }

    static void Main()
    {
        Console.WriteLine("This is a multi-task program, it can do 3 tasks.");
        Console.WriteLine("1. Revers a number\n2. Calculating average value of array of integers");
        Console.WriteLine("3.Solving a linear equation a * x + b = 0");
        Console.Write("Please insert the number of which method do you want to execute:");
        int choose = int.Parse(Console.ReadLine());
        if (choose == 1)
        {
            Console.Write("The number which you want to reverse: ");
            int number = int.Parse(Console.ReadLine());
            if (number < 0)
            {
                Console.WriteLine("The number should be non-negative!");
                return;
            }
            else
            {
                ReversNumber(number);
            }
        }
        else if (choose == 2)
        {
            Console.Write("How many numbers do you want to insert: ");
            int n = int.Parse(Console.ReadLine());
            if (n <= 0)
            {
                Console.WriteLine("It should be bigger than 0!");
                return;
            }
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                if (input == "")
                {
                    Console.WriteLine("You should insert a number!");
                    return;
                }
                arr[i] = int.Parse(input);
            }
            Average(arr);
        }
        else if (choose == 3)
        {
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());

            if (a == 0)
            {
                Console.WriteLine("Coeficient a should be different than 0!");
                return;
            }
            Console.WriteLine("The linear equation looks like: {0} * x + {1} = 0", a, b);
            LinearEquation(a, b);
        }
    }
}

