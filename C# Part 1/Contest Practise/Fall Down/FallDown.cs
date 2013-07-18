using System;

class FallDown
{
    static void Main()
    {
        int[,] matrix = new int[8, 8];
        for (int i = 0; i < 8; i++)
        {
            int number = int.Parse(Console.ReadLine());
            for (int j = 0; j < 8; j++)
            {
                int bit = (number >> j) & 1;
                matrix[i, j] = bit;
            }
        }

        //for (int i = 0; i < 8; i++)
        //{

        //    for (int j = 0; j < 8; j++)
        //    {
        //        Console.Write(matrix[i, j] + " ");
        //    }
        //    Console.WriteLine();
        //}
        //Console.WriteLine();

        //while (true)
        //{
        //    for (int col = 0; col < 8; col++)
        //    {
        //        for (int row = 6; row >= 0; row--)
        //        {
        //            if (matrix[row, col] != 0 && matrix[row + 1, col] == 0)
        //            {
        //                matrix[row, col] = 0;
        //                matrix[row + 1, col] = 1;
        //            }
        //            for (int i = 0; i < 8; i++)
        //            {
                        
        //                for (int j = 0; j < 8; j++)
        //                {
        //                    Console.Write(matrix[i, j] + " ");
        //                }
        //                Console.WriteLine();
        //            }
        //            Console.WriteLine();
        //            if (matrix[row, col] != 0 && matrix[row + 1, col] != 0)
        //            {
        //                return;
        //            }
        //        }
        //    }
        //}

        MovingBits(matrix);
        //for (int i = 0; i < 8; i++)
        //{

        //    for (int j = 0; j < 8; j++)
        //    {
        //        Console.Write(matrix[i, j] + " ");
        //    }
        //    Console.WriteLine();
        //}
        int n0 = 0;
        int n1 = 0;
        int n2 = 0;
        int n3 = 0;
        int n4 = 0;
        int n5 = 0;
        int n6 = 0;
        int n7 = 0;

        for (int i = 0; i < 8; i++)
        {
            if (matrix[0, i] != 0)
            {
                n0 += (int)Math.Pow(2, i);
            }
        }
        for (int i = 0; i < 8; i++)
        {
            if (matrix[1, i] != 0)
            {
                n1 += (int)Math.Pow(2, i);
            }
        }
        for (int i = 0; i < 8; i++)
        {
            if (matrix[2, i] != 0)
            {
                n2 += (int)Math.Pow(2, i);
            }
        }
        for (int i = 0; i < 8; i++)
        {
            if (matrix[3, i] != 0)
            {
                n3 += (int)Math.Pow(2, i);
            }
        }
        for (int i = 0; i < 8; i++)
        {
            if (matrix[4, i] != 0)
            {
                n4 += (int)Math.Pow(2, i);
            }
        }
        for (int i = 0; i < 8; i++)
        {
            if (matrix[5, i] != 0)
            {
                n5 += (int)Math.Pow(2, i);
            }
        }
        for (int i = 0; i < 8; i++)
        {
            if (matrix[6, i] != 0)
            {
                n6 += (int)Math.Pow(2, i);
            }
        }
        for (int i = 0; i < 8; i++)
        {
            if (matrix[7, i] != 0)
            {
                n7 += (int)Math.Pow(2, i);
            }
        }
        Console.WriteLine(n0);
        Console.WriteLine(n1);
        Console.WriteLine(n2);
        Console.WriteLine(n3);
        Console.WriteLine(n4);
        Console.WriteLine(n5);
        Console.WriteLine(n6);
        Console.WriteLine(n7);
    }

    private static void MovingBits(int[,] matrix)
    {
        for (int i = 0; i < 8; i++)
        {
            for (int col = 0; col < 8; col++)
            {
                for (int row = 6; row >= 0; row--)
                {

                    if (matrix[row, col] != 0 && matrix[row + 1, col] == 0)
                    {
                        matrix[row, col] = 0;
                        matrix[row + 1, col] = 1;
                    }
                }
            }
        }
    }
}

