using System;

class TelerikLogo
{
    static void Main()
    {
        int x = int.Parse(Console.ReadLine());

        int width = (x / 2) + 1 + x + x + (x / 2) + 1 - 3;

        Console.Write(new string('.', x/2));
        Console.Write("*");
        int middle = width - (2 * (x / 2 + 1));
        Console.Write(new string('.', middle));
        Console.Write("*");
        Console.WriteLine(new string('.', x / 2));
        middle -= 2;
        int hornLegnth = x / 2;

        for (int i = 1; i < x - 1; i++)
        {
            // add horns
            if (i <= x/2 + 1)
            {
                hornLegnth--;
                if (hornLegnth > 0)
                {
                    Console.Write(new string('.', hornLegnth));
                }
                if (hornLegnth >= 0)
                {
                    Console.Write("*");
                }
                Console.Write(new string('.', i-1));

            }
            else
            {
                Console.Write(new string('.', x / 2));
            }
            if (i <= x / 2 + 1)
            {
                Console.Write(new string('.', i - 1));
                if (hornLegnth >= 0)
                {
                    Console.Write("*");
                }
                if (hornLegnth > 0)
                {
                    Console.Write(new string('.', hornLegnth));
                }
            }
            else
            {
                Console.Write(new string('.', x / 2));
            }
            Console.Write(new string('.', i));
            Console.Write("*");
            Console.Write(new string('.', middle));
            middle -= 2;
            Console.Write("*");
            Console.Write(new string('.', i));
            Console.Write(new string('.', x / 2));
            Console.WriteLine();
        }

        Console.Write(new string('.', width/2));
        Console.Write("*");
        Console.Write(new string('.', width/2));
        Console.WriteLine();

        int leftRight = x - 2;
        middle = 1;

        for (int i = 0; i < x-1; i++)
        {
            Console.Write(new string('.', x / 2));
            Console.Write(new string('.', leftRight));
            Console.Write("*");
            Console.Write(new string('.', middle));
            Console.Write("*");
            Console.Write(new string('.', leftRight));
            Console.Write(new string('.', x / 2));
            middle += 2;
            leftRight--;
            Console.WriteLine();
        }

        middle -= 4;
        for (int i = 1; i <= x-2; i++)
        {
            Console.Write(new string('.', x / 2));
            Console.Write(new string('.', i));
            Console.Write("*");
            Console.Write(new string('.', middle));
            Console.Write("*");
            Console.Write(new string('.', i));
            Console.Write(new string('.', x / 2));

            middle -= 2;
            Console.WriteLine();
        }
        Console.Write(new string('.', width / 2));
        Console.Write("*");
        Console.Write(new string('.', width / 2));
    }
}

