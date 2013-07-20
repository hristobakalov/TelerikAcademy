using System;
using System.Collections.Generic;
using System.Linq;

class ChecksIfSumIsZero
{
    static void Main()
    {
        //We are given 5 integer numbers. Write a program that checks if the sum of some subset of them is 0.
        //Example: 3, -2, 1, 1, 8  1+1-2=0.

        Console.Write("Insert the first number: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Insert the second number: ");
        int secondNumber = int.Parse(Console.ReadLine());
        Console.Write("Insert the third number: ");
        int thirdNumber = int.Parse(Console.ReadLine());
        Console.Write("Insert the forth number: ");
        int forthNumber = int.Parse(Console.ReadLine());
        Console.Write("Insert the fifth number: ");
        int fifthNumber = int.Parse(Console.ReadLine());


        int[] array = new int[] { firstNumber, secondNumber, thirdNumber, forthNumber, fifthNumber };


        for (int index = 0; index < 32; index++) // 31 are all the possible variations to sum the numbers
        {
            int sum = 0;

            List<int> arrayPossitons = new List<int>(); //here I save the positions of the numbers which sum is 0

            for (int i = 0; i < 5; i++)
            {

                if ((1 << i & index) != 0)
                {
                    arrayPossitons.Add(array[i]); 
                }
            }

            if (arrayPossitons.Sum() == 0 && arrayPossitons.Count!=0) //checks if there is sum = 0 and the array is not empty
            {
                Console.WriteLine("yes there is");
                for (int j = 0; j < arrayPossitons.Count; j++)
                {
                    Console.Write("{0} ", arrayPossitons[j]);
                }
                Console.WriteLine();
            }
        }

       
    }
}
