using System;

//* Write a class Matrix, to holds a matrix of integers.
//Overload the operators for adding, subtracting and multiplying of matrices,
//indexer for accessing the matrix content and ToString().

class ClassMatrix
{
    static void addingMatrices(int[,] oneMatrix, int[,] twoMatrix)
    {
        int[,] summedMatrices = new int[oneMatrix.GetLength(0), oneMatrix.GetLength(1)];
        for (int rows = 0; rows < oneMatrix.GetLength(0); rows++)
        {
            for (int cols = 0; cols < oneMatrix.GetLength(1); cols++)
            {
                summedMatrices[rows, cols] = oneMatrix[rows, cols] + twoMatrix[rows, cols];
            }
        }
        Console.WriteLine();
    }

    static void subtractingMatrices(int[,] oneMatrix, int[,] twoMatrix)
    {
        int[,] subtractedMatrices = new int[oneMatrix.GetLength(0), oneMatrix.GetLength(1)];
        for (int rows = 0; rows < oneMatrix.GetLength(0); rows++)
        {
            for (int cols = 0; cols < oneMatrix.GetLength(1); cols++)
            {
                subtractedMatrices[rows, cols] = oneMatrix[rows, cols] - twoMatrix[rows, cols];
            }
        }
    }

    static void multiplyingMatrices(int[,] oneMatrix, int[,] twoMatrix)
    {
        int[,] multipliedMatrices = new int[oneMatrix.GetLength(0), oneMatrix.GetLength(1)];
        for (int cols = 0; cols < multipliedMatrices.GetLength(1); cols++)
        {
            for (int row = 0; row < multipliedMatrices.GetLength(0); row++)
            {
                multipliedMatrices[row,cols] = 5;
            } 
        }
    }

    static void Main()
    {
        

        int[,] firstMatrix = { 
                             {10, 15, 1},
                             {50, 17, 3}
                             };
        int[,] secondMatrix = { 
                             {11, 18, 5},
                             {13, 24, 0}
                             };
        addingMatrices(firstMatrix, secondMatrix);

        string[] adad = { "4", "5" };
        int[] addf = int.Parse(adad);
        Console.WriteLine();
    }
}

