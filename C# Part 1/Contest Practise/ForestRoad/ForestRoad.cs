using System;

class ForestRoad
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int width = n;
        int height = 2 * n - 1;
        char asterisk = '*';
        int position = 0;

        char[] trees = { '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.'};
        
        for (int coll = 0; coll < height; coll++)
        {
            for (int row = 0; row < width; row++)
            {
                while (position < width)
                {
                    trees[position] = asterisk;
                    for (int i = 0; i < width; i++)
                    {
                        Console.Write(trees[i]);
                    }
                    trees[position] = '.';
                    position++;
                    Console.WriteLine();
                }

                while (position <= width)
                {
                    
                    position-= 2;
                    if (position < 0)
                    {
                        position = 0;
                        return;
                    }
                    trees[position] = asterisk;
                    for (int i = 0; i < width; i++)
                    {
                        Console.Write(trees[i]);
                    }
                    trees[position] = '.';
                    position++;
                    
                    Console.WriteLine();
                }

            }
        }
    }
}

