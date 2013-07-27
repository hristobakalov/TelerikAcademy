using System;
using System.IO;

//Write a program that reads a text file containing a square matrix of numbers
//and finds in the matrix an area of size 2 x 2 with a maximal sum of its elements.
//The first line in the input file contains the size of matrix N.
//Each of the next N lines contain N numbers separated by space.
//The output should be a single number in a separate text file. Example:
//4
//2 3 3 4
//0 2 3 4	->   17
//3 7 1 2
//4 3 3 2

class FindAreaWithMaxSum
{
    static void Main()
    {
        StreamReader reader = new StreamReader("input.txt");
        StreamWriter writer = new StreamWriter("output.txt");

        using (reader)
        {
            using (writer)
            {
                int matrixSize = int.Parse(reader.ReadLine());
                int[,] matrix = new int[matrixSize, matrixSize];

                for (int i = 0; i < matrixSize; i++)
                {
                    string inputNumbers = reader.ReadLine();
                    string[] numbers = inputNumbers.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

                    for (int j = 0; j < numbers.Length; j++)
                    {
                        matrix[i, j] = int.Parse(numbers[j]);
                    }
                }
                long maxSum = long.MinValue;
                for (int row = 0; row < matrixSize - 1; row++)
                {
                    for (int col = 0; col < matrixSize - 1; col++)
                    {
                        long sum = long.MinValue;
                        sum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];
                        if (sum > maxSum)
                        {
                            maxSum = sum;
                        }
                    }
                }
                writer.WriteLine(maxSum);
            }
        }
    }
}

