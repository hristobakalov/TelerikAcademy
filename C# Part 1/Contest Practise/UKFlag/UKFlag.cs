using System;

class UKFlag
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int innerDots = (n / 2) - 1;
        int outerDots = 0;

        for (int i = 0; i < (n/2); i++)
        {
            Console.WriteLine("{0}\\{1}|{1}/{0}", new string('.', outerDots), new string('.', innerDots));
            innerDots--;
            outerDots++;
        }

        Console.WriteLine("{0}*{0}", new string('-', n/2));

        outerDots--;
        innerDots++;
        for (int i = 0; i < n/2; i++)
        {
           
            Console.WriteLine("{0}/{1}|{1}\\{0}", new string('.', outerDots), new string('.', innerDots));
            innerDots++;
            outerDots--;
        }
    }
}

