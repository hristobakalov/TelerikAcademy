using System;

class ReadTwoArrays
{
    static void Main()
    {
        //Write a program that reads two arrays from the console and compares them element by element.

        Console.WriteLine("Enter the length of the first array");
        int lengthArrayOne = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the length of the second array");
        int lengthArrayTwo = int.Parse(Console.ReadLine());

        int[] firstArray = new int[lengthArrayOne];
        int[] secondArray = new int[lengthArrayTwo];

        if (lengthArrayOne != lengthArrayTwo)
        {
            Console.WriteLine("The two arrays aren't equal!");
        }
        else
        {
            bool areEqual = true;

            //initializing the arrays
            Console.WriteLine("You can now enter {0} integers for the first array!", lengthArrayOne);
            for (int i = 0; i < lengthArrayOne; i++)
            {
                int input = int.Parse(Console.ReadLine());
                firstArray[i] = input;
            }
            Console.WriteLine("You can now enter {0} integers for the second array!", lengthArrayTwo);
            for (int i = 0; i < lengthArrayTwo; i++)
            {
                int input = int.Parse(Console.ReadLine());
                secondArray[i] = input;
            }

            //compares the elemnts on by one
            for (int i = 0; i < lengthArrayOne; i++)
            {
                if (firstArray[i] != secondArray[i])
                {
                    areEqual = false;
                    break;
                }
            }
            Console.WriteLine("The arrays are equal - {0}", areEqual);
        }
    }
}

