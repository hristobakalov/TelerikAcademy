using System;

class Carpets
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int elements = n;
        int center = elements / 2;


        int outerDots = (n / 2) - 1;
       

        for (int i = 0; i <= n/2; i++)
        {
            int elPosition = 1;
            while (elPosition <= elements)
            {
             
             if ((elPosition <= center - i) || (elPosition > center + 1))
                {
                Console.Write(".");
                elPosition++;
                }
            else
                {
                Console.Write("+");
                elPosition++;
                }
            }
            Console.WriteLine();
            //Console.WriteLine("{0}/\\{0}", new string('.', outerDots));
            //outerDots--;
        }
    }
}

