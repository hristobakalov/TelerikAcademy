using System;

class FirstProblem
{
    static void Main()
    {
        //int line1 = 10;
        //int line2 = 20;
        //int line3 = 25;
        //int line4 = 30;
        //int line5 = 42;
        //int line6 = 38;
        //int line7 = 15;
        //int line8 = 23;
        //int line9 = 18;
        //int line10 = 36;
        //int line11 = 70;

        int area = 250;
        double cost = 0;
        for (int i = 1; i <= 11; i++)
        {
            int number = int.Parse(Console.ReadLine());
            if (i % 2 == 0)
            {
                area -= number;

            }
            if (i == 1)
            {
                cost += number * 0.5;
            }
            if (i == 3)
            {
                cost += number * 0.4;
            }
            if (i == 5)
            {
                cost += number * 0.25;
            }
            if (i == 7)
            {
                cost += number * 0.6;
            }
            if (i == 9)
            {
                cost += number * 0.3;
            }
            if (i == 11)
            {
                cost += number * 0.4;
            }
        }
        Console.WriteLine("Total costs: {0:F}", cost);
        if (area > 0)
        {
            Console.WriteLine("Beans area: {0}", area);
        }
        else if (area == 0)
        {
            Console.WriteLine("No area for beans");
        }
        else if (area < 0)
        {
            Console.WriteLine("Insufficient area");
        }
    }
}

