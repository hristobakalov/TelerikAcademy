using System;
using System.Collections.Generic;
using System.Numerics;

class CalculatingFactoriel
{
    //Write a program to calculate n! for each n in the range [1..100].
    //Hint: Implement first a method that multiplies a number represented as array of digits by given integer number.

    static int[] NumberToArray(string number)
    {
        string digit = "";
        int[] arr = new int[number.Length];
        for (int i = arr.Length - 1, counter = 0; i >= 0; i--, counter++)
        {
            digit += number[i];
            arr[counter] = Convert.ToInt32(digit) % 10;
            digit = "";


        }
        return arr;
    }
    static int[] Factoriel(int[] numberArr, int[] anotherArr)
    {
        BigInteger productInt = 0;
        for (int i = 0; i < numberArr.Length; i++)
        {
            BigInteger numberpowered = (BigInteger)Math.Pow(10, i);
            for (int k = 0; k < anotherArr.Length; k++)
            {
                BigInteger anotherpowered = (BigInteger)Math.Pow(10, k);
                productInt += anotherArr[k] * anotherpowered * numberArr[i] * numberpowered;
            }
        }
        string productString = productInt.ToString();
        return NumberToArray(productString);
    }

    static void Main()
    {
        Console.Write("N = ");
        string n = Console.ReadLine();
        
        int nToNumber = int.Parse(n);
        int[] nFactoriel = Factoriel(NumberToArray("1"), NumberToArray("2"));
        for (int i = 3; i <= nToNumber; i++)
        {
            nFactoriel = Factoriel(nFactoriel, NumberToArray(i.ToString()));
        }
        Console.Write("N! = ");
        for (int i = nFactoriel.Length - 1; i >= 0; i--)
        {
            Console.Write(nFactoriel[i]);
        }
        Console.WriteLine();
    }
}

