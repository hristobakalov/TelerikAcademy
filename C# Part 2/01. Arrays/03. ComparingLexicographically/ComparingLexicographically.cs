using System;

class ComparingLexicographically
{
    static void Main()
    {
        //Write a program that compares two char arrays lexicographically (letter by letter).

        Console.WriteLine("Enter the length of the first array");
        int lengthArrayOne = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the length of the second array");
        int lengthArrayTwo = int.Parse(Console.ReadLine());

        char[] firstArray = new char[lengthArrayOne];
        char[] secondArray = new char[lengthArrayTwo];

        if (lengthArrayOne != lengthArrayTwo)
        {
            Console.WriteLine("The two arrays are different!");
        }
        else
        {
            bool areEqual = true;

            //initializing the arrays
            Console.WriteLine("You can now enter {0} chars for the first array!", lengthArrayOne);
            for (int i = 0; i < lengthArrayOne; i++)
            {
                char input = char.Parse(Console.ReadLine());
                firstArray[i] = input;
            }

            Console.WriteLine("You can now enter {0} chars for the second array!", lengthArrayTwo);
            for (int i = 0; i < lengthArrayTwo; i++)
            {
                char input = char.Parse(Console.ReadLine());
                secondArray[i] = input;
            }

            //comparing them one by one
            for (int i = 0; i < lengthArrayOne; i++)
            {
                if (firstArray[i] != secondArray[i])
                {
                    areEqual = false;
                    break;
                }
            }
            Console.WriteLine("The arrays are the same - {0}", areEqual);
        }
    }
}

