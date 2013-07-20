using System;

class MaximalIncreasingSequence
{
    static void Main()
    {
        //Write a program that finds the maximal increasing sequence in an array. 
        //Example: {3, 2, 3, 4, 2, 2, 4}  {2, 3, 4}.

        int[] array = {3, 3, 4, 5, 6, 8, 9, 10, 11, 12, 13, 2, 2, 4};

        //print the array
        foreach (int numberInSequence in array)
        {
            Console.Write(numberInSequence + " ");
        }
        Console.WriteLine();

        int maxSequence = 1;
        int tempSequence = 1;
        int element = 0;
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] + 1 == array[i + 1])//check if this element plus 1 equals the next element (example 1, 2, 5. 1+1 == 2 true, 2+1 == 5 false)
            {
                tempSequence++;
            }
            else
            {
                tempSequence = 1;
            }

            if (tempSequence > maxSequence) //checks if tempSeq is bigger than MaxSeq
            {
                maxSequence = tempSequence;
                element = array[i] - maxSequence + 2;

            }
        }

        //prints the biggest sequence
        Console.Write("The biggest sequence is: ");
        for (int i = 0; i < maxSequence; i++)
        {
            Console.Write((element + i) + " ");
        }
    }
}

