using System;

class BitBall
{
    static void Main()
    {
        int fieldLength = 8;
        int[,] matrix = new int[fieldLength, fieldLength];
        
        for (int i = 0; i < fieldLength; i++)
        {
            int number = int.Parse(Console.ReadLine());

            for (int j = 0; j < fieldLength; j++)
            {
                int bit = (number >> j) & 1;
                if (bit==1)
                {
                    matrix[i, j] = 1;
                }
            }
        }

        for (int i = 0; i < fieldLength; i++)
        {
            int number = int.Parse(Console.ReadLine());

            for (int j = 0; j < fieldLength; j++)
            {
                int bit = (number >> j) & 1;

                if (bit == 1)
                {
                    if (matrix[i,j]==1)
                    {
                        matrix[i, j] = 0;
                    }
                    else
                    {
                        matrix[i, j] = 2;
                    }
                }
            }
        }
        int x = 0;
        int y = 0;
        for (int col = 0; col < fieldLength; col++)
        {
            for (int row = 0; row < fieldLength; row++)
            {
                if (matrix[row,col]==1)
                {
                    break;
                }
                else if (matrix[row,col]==2)
                {
                    y++;
                    break;
                }
            }
        }

        for (int col = 0; col < fieldLength; col++)
        {
            for (int row = fieldLength-1; row >= 0; row--)
            {
                if (matrix[row, col] == 1)
                {
                    x++;
                    break;
                }
                else if (matrix[row, col] == 2)
                {
                    break;
                }
            }
        }
        Console.WriteLine("{0}:{1}",x, y);
    }
}

