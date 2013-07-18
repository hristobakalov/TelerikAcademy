using System;

class Sheets
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());

        for (int i = 0; i < 11; i++)
        {
            int bitToTake = i;
            int mask = i << bitToTake;
            int numberAndMask = input & mask;
            int bashSiBit = numberAndMask >> bitToTake;
            if (bashSiBit == 0)
            {
                Console.WriteLine("A" + (10 - i));
            }
        }
    }
}

