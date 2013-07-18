using System;
using System.Collections.Generic;

class TribonacciTriangle
{
    static void Main()
    {
        long firstNum = long.Parse(Console.ReadLine());
        long secondNum = long.Parse(Console.ReadLine());
        long thirdNum = long.Parse(Console.ReadLine());
        int l = int.Parse(Console.ReadLine());
        int numbersCount = 0;
        for (int i = 1; i <= l; i++)
        {
            numbersCount += i;
        }
        List<long> tribonacci = new List<long>() { firstNum, secondNum, thirdNum };

        for (int i = 0; i < (numbersCount/3); i++)
        {
            long mask = thirdNum;
            firstNum = secondNum + thirdNum + firstNum;
            tribonacci.Add(firstNum);
            secondNum = firstNum + thirdNum + secondNum;
            tribonacci.Add(secondNum);
            thirdNum = firstNum + secondNum + thirdNum;
            tribonacci.Add(thirdNum);
        }


        int index = 0;
        for (int i = 1; i <= l; i++)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write(tribonacci[index] + " ");
                index++;
            }
            Console.WriteLine();
        }
    }
}

