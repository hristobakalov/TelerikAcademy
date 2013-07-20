using System;

class SumingNumbersInArray
{
    //Write a method that adds two positive integer numbers represented as arrays of digits
    //(each array element arr[i] contains a digit; the last digit is kept in arr[0]). 
    //Each of the numbers that will be added could have up to 10 000 digits.

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

    static int[] SumingArrays(int[] arrFirst, int[] arrSecond)
    {
        bool carried = false;
        int arrLength = Math.Max(arrSecond.Length, arrFirst.Length);
        if (arrSecond.Length > arrFirst.Length)
        {
            int[] temp = arrFirst;
            arrFirst = arrSecond;
            arrSecond = temp;
        }

        if (arrSecond.Length == arrFirst.Length)
        {
            int[] summedArrays = new int[arrLength + 1];

            for (int i = 0; i < summedArrays.Length - 1; i++)
            {
                if (((arrFirst[i] + arrSecond[i]) > 9) && carried == true)
                {
                    summedArrays[i] = (arrFirst[i] + arrSecond[i] + 1) % 10;
                }
                else if ((arrFirst[i] + arrSecond[i]) > 9)
                {
                    carried = true;
                    summedArrays[i] = (arrFirst[i] + arrSecond[i]) % 10;
                }
                else if ((arrFirst[i] + arrSecond[i] <= 9) && carried != true)
                {
                    summedArrays[i] = arrFirst[i] + arrSecond[i];
                }
                else if ((arrFirst[i] + arrSecond[i] < 9) && carried == true)
                {
                    summedArrays[i] = arrFirst[i] + arrSecond[i] + 1;
                    carried = false;
                }
                else if ((arrFirst[i] + arrSecond[i] == 9) && carried == true)
                {
                    summedArrays[i] = (arrFirst[i] + arrSecond[i] + 1) % 10;
                }
                if ((i == summedArrays.Length - 2) && carried == true)
                {
                    summedArrays[summedArrays.Length - 1] = 1;
                }
            }
            Array.Reverse(summedArrays);
            return summedArrays;
        }
        else
        {
            for (int i = 0; i < arrSecond.Length; i++)
            {
                if (((arrFirst[i] + arrSecond[i]) > 9) && carried == true)
                {
                    arrFirst[i] = (arrFirst[i] + arrSecond[i] + 1) % 10;
                }
                else if ((arrFirst[i] + arrSecond[i]) > 9)
                {
                    carried = true;
                    arrFirst[i] = (arrFirst[i] + arrSecond[i]) % 10;
                }
                else if ((arrFirst[i] + arrSecond[i] <= 9) && carried != true)
                {
                    arrFirst[i] = arrFirst[i] + arrSecond[i];
                }
                else if ((arrFirst[i] + arrSecond[i] < 9) && carried == true)
                {
                    arrFirst[i] = arrFirst[i] + arrSecond[i] + 1;
                    carried = false;
                }
                else if ((arrFirst[i] + arrSecond[i] == 9) && carried == true)
                {
                    arrFirst[i] = (arrFirst[i] + arrSecond[i] + 1) % 10;
                }
                if ((i == arrSecond.Length - 1) && carried == true)
                {
                    arrFirst[arrSecond.Length] += 1;
                }
            }
            Array.Reverse(arrFirst);
            return arrFirst;
        }
        
    }

    static void Main()
    {
        Console.Write("First number = ");
        string firstNum = Console.ReadLine();
        Console.Write("Second number = ");
        string secondNum = Console.ReadLine();
        Console.WriteLine("The two numbers summed equals {0}", string.Join(" ", (SumingArrays(NumberToArray(firstNum), NumberToArray(secondNum)))));



    }
}

