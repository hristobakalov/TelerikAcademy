using System;

class IndexMultiplaiedByFive
{
    static void Main()
    {
        //Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5.
        //Print the obtained array on the console.

        int[] array = new int[20];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = i * 5; // gets the index i and multiplyes it by 5
            Console.Write(array[i] + " "); //prints it on the console
        }
    }
}



