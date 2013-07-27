using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[,] arraySpiral = new int[n, n];

        string direction = "right";

        int currentRow = 0;
        int currentCol = 0;

        for (int i = 1; i <= n*n; i++)
        {
            if 
                (direction == "right" && (currentCol >= n || (arraySpiral[currentRow, currentCol] != 0)))
                
            {
                currentCol--;
                currentRow++;
                direction = "down";
                
                
            }
            else if (direction == "down" && (currentRow >= n || (arraySpiral[currentRow, currentCol] != 0)))
            {
                currentRow--;
                currentCol--;
                direction = "left";
            }
            else if (direction == "left" && (currentCol < 0 || (arraySpiral[currentRow, currentCol] != 0)))
            {
                currentCol++;
                currentRow--;
                direction = "up";
            }
            else if (direction == "up" && (currentRow < 0 || (arraySpiral[currentRow, currentCol] != 0)))
            {
                currentRow++;
                currentCol++;
                direction = "right";
            }

            arraySpiral[currentRow, currentCol] = i;

            if (direction == "right")
            {
                currentCol++;
            }
            else if (direction == "down")
            {
                    currentRow++;
            }
            else if (direction == "left")
            {
                currentCol--;
            }
            else if (direction == "up")
            {
                currentRow--;
            }
        }

        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                Console.Write("{0,4 }",arraySpiral[row,col]);
            }
            Console.WriteLine();
        }
    }
}

