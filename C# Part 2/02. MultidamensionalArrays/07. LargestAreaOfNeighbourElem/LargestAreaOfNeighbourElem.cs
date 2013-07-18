using System;
using System.Collections.Generic;

//* Write a program that finds the largest area of equal neighbor elements in a rectangular matrix and prints its size.
//Hint: you can use the algorithm "Depth-first search" or "Breadth-first search" (find them in Wikipedia).

class LargestAreaOfNeighbourElem
{
    static int counter = 1;

    static void BreadthSearch(int[,] arr, bool[,] boolArr, int row, int col)
    {

        //bool[,] tempArr = new bool[arr.GetLength(0), arr.GetLength(1)];
        if ((row >= 0 || row < arr.GetLength(1) || col >= 0 || col < arr.GetLength(0)) && !boolArr[row, col])
        {
            boolArr[row, col] = true;
            //tempArr[row, col] = true;

            if (col < arr.GetLength(0) - 1 )
            {
                if ((arr[row, col] == arr[row, col + 1]) && !boolArr[row, col + 1])
                {
                    //tempArr[row, col + 1] = true;
                    counter++;

                    BreadthSearch(arr, boolArr, row, col + 1);
                }
            }

            if (col > 0)
            {
                if ((arr[row, col] == arr[row, col - 1]) && !boolArr[row, col - 1])
                {
                    counter++;

                    BreadthSearch(arr, boolArr, row, col - 1);
                }

                if (row > 0)
                {
                    if (arr[row, col] == arr[row - 1, col] && !boolArr[row - 1, col])
                    {
                        counter++;

                        BreadthSearch(arr, boolArr, row - 1, col);
                    }
                }
            }
            if (row < arr.GetLength(1) - 1)
            {
                if ((arr[row, col] == arr[row + 1, col]) && !boolArr[row + 1, col])
                {
                    counter++;

                    BreadthSearch(arr, boolArr, row + 1, col);
                }
            }


        }
    }


    static void Main()
    {
        int[,] arr =
        {
            { 1, 3, 2, 2, 2, 4},
            { 3, 3, 3, 2, 4, 4},
            { 4, 3, 1, 2, 3, 3},
            { 4, 3, 1, 3, 3, 1},
            { 4, 3, 3, 3, 1, 1},
        };
        bool[,] boolArr = new bool[arr.GetLength(0), arr.GetLength(1)];
        for (int row = 0; row < arr.GetLength(1); row++)
        {
            for (int col = 0; col < arr.GetLength(0); col++)
            {
                BreadthSearch(arr, boolArr, row, col);
                Console.WriteLine(counter);
                counter = 1;
            }
        }
    }
}

