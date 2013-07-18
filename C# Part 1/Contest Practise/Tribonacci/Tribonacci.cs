using System;

class Tribonacci
{
    static void Main()
    {
        int firstNum = int.Parse(Console.ReadLine());
        int secondNum = int.Parse(Console.ReadLine());
        int thirdNum = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());

        int deviser = n % 3;
        if (deviser == 1)
        {
            n += 2;
        }
        else if (deviser == 2)
        {
            n++;
        }
        int numberOfCycles = (n / 3) - 1;
        for (int i = 0; i < numberOfCycles; i++)
        {
            firstNum = firstNum + secondNum + thirdNum;
            secondNum = secondNum + firstNum + thirdNum;
            thirdNum = thirdNum + firstNum + secondNum;
        }
        if (deviser == 0)
        {
            Console.WriteLine(thirdNum);
        }
        else if (deviser == 1)
        {
            Console.WriteLine(firstNum);
        }
        else
        {
            Console.WriteLine(secondNum);
        }
        
    }
}

