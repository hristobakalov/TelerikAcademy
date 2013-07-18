using System;

class MaximalSequenceOfElements
{
    static void Main()
    {
        //Write a program that finds the maximal sequence of equal elements in an array.
		//Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1}  {2, 2, 2}.

        int[] array = {2, 1, 1, 1, 1, 1, 2, 3, 3, 3, 3, 2, 2, 2, 2, 2, 2, 1};
        
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
            if (array[i] == array[i + 1]) //check if the next element equals this element
            {
                tempSequence++;
            }
            else
            {
                tempSequence = 1;
            }

            if (tempSequence > maxSequence) //checks if the tempSeq is bigger than the maxSeq
            {
                maxSequence = tempSequence;
                element = array[i];
                
            }
        }

        //prints the biggest sequence
        Console.Write("The biggest sequence is: ");
        for (int i = 0; i < maxSequence ; i++)
        {
            Console.Write(element + " ");
        }
    }
}

