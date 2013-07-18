using System;

class Pillars
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

        int counterLeft = 0;
        int counterRight = 0;
        bool pillarFound = false;

        for (int pillar = 7; pillar >= 0; pillar--)
        {
            for (int leftRow = 0; leftRow < 8; leftRow++)
            {
                for (int leftCol = 7; leftCol > pillar; leftCol--)
                {
                    if (matrix[leftRow,leftCol] == 1)
                    {
                        counterLeft++;
                    }
                }
            }

            for (int rightRow = 0; rightRow < 8; rightRow++)
            {
                for (int rightCol = 0; rightCol < pillar; rightCol++)
                {
                    if (matrix[rightRow, rightCol] == 1)
                    {
                        counterRight++;
                    }
                }
            }
            
            if (counterLeft == counterRight)
            {
                Console.WriteLine(pillar);
                Console.WriteLine(counterLeft);
                pillarFound = true;
                break;
            }
            else
            {
                counterLeft = 0;
                counterRight = 0;
            }
        }
        if (pillarFound == false)
        {
            Console.WriteLine("No");
        }
    }
}

