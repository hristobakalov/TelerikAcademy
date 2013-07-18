using System;

class FirTree
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int asteriskIndex = 1;
        int dotsAfter = n - 2;
        for (int i = (n-2); i >= 0; i--)
        {
            string dot = new string('.', i);
            Console.Write(dot);
            
            while (asteriskIndex <= (2 * (n - 2) +1))
	        {
	         string asteriks = new string('*', asteriskIndex);
                Console.Write(asteriks);
                
                asteriskIndex += 2;
                break;
	        }
            while (dotsAfter >= 0)
            {
            string dotsTwo = new string('.', dotsAfter);
            Console.Write(dotsTwo);
            dotsAfter--;
            Console.WriteLine();
            break;
            }
        }
        string lastLineDots = new string('.', (n - 2));
        Console.Write(lastLineDots);
        Console.Write("*");
        Console.Write(lastLineDots);
    }
}

