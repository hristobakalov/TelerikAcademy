using System;
using System.Collections.Generic;

namespace _12.SubtractAndMultiplicatePolynoms
{
    class SubtractAndMultiplicatePolynoms
    {
        //Extend the previous program to support also subtraction and multiplication of polynomials.

        static int[] Multiplication(List<int> arrFirst, List<int> arrSecond)
        {
            int[] result = new int[arrFirst.Count + arrSecond.Count - 1];

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = 0;
            }

            for (int i = 0; i < arrFirst.Count; i++)
            {
                for (int k = 0; k < arrSecond.Count; k++)
                {
                    int index = i + k;
                    result[index] += arrFirst[i] * arrSecond[k];
                }
            }
            return result;
        }

        static List<int> Subtraction(List<int> arrFirst, List<int> arrSecond)
        {
            bool areSwiteched = false;
            if (arrSecond.Count > arrFirst.Count)
            {
                List<int> temp = new List<int>();
                temp = arrFirst;
                arrFirst = arrSecond;
                arrSecond = temp;
                areSwiteched = true;
            }
            for (int i = 0; i < arrSecond.Count; i++)
            {
                arrFirst[i] -= arrSecond[i];
                if (areSwiteched)
                {
                    arrFirst[i] *= -1;
                }
            }
            return arrFirst;
        }

        static void Main()
        {
            Console.WriteLine("Insert coefficients of the first polynom (starting from x^0, x^1, etc...):");
            List<int> arr = new List<int>();
            string input = "a";
            while (input != "")
            {
                input = Console.ReadLine();
                if (input != "")
                {
                    int inputInt = int.Parse(input);
                    arr.Add(inputInt);
                }

            }
            Console.Write("Your polynom looks like: ");
            PrintOnConsole(arr);

            Console.WriteLine("Insert coefficients of the second polynom (starting from x^0, x^1, etc...):");
            List<int> arrSecond = new List<int>();
            string inputSecond = "a";
            while (inputSecond != "")
            {
                inputSecond = Console.ReadLine();
                if (inputSecond != "")
                {
                    int inputInt = int.Parse(inputSecond);
                    arrSecond.Add(inputInt);
                }

            }
            Console.Write("Your polynom looks like: ");
            PrintOnConsole(arrSecond);

            int[] multiplicating = Multiplication(arr, arrSecond);
            Console.Write("Multiplication: ");

            PrintOnConsole(multiplicating);

            List<int> subtract = new List<int>();
            subtract = Subtraction(arr, arrSecond);
            Console.Write("Subtraction: ");
            PrintOnConsole(subtract);
        }

        private static void PrintOnConsole(List<int> list)
        {
            for (int i = list.Count - 1; i >= 0; i--)
            {
                if (i != 0 && list[i] != 0)
                {
                    Console.Write(list[i] + "*(x^" + i + ") + ");
                }
                else if (i == 0)
                {
                    Console.Write(list[i]);
                }
            }
            Console.WriteLine("\n");
        }
        private static void PrintOnConsole(int[] arr)
        {
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (i != 0 && arr[i] != 0)
                {
                    Console.Write(arr[i] + "*(x^" + i + ") + ");
                }
                else if (i == 0)
                {
                    Console.Write(arr[i]);
                }
            }
            Console.WriteLine("\n");
        }
    }
}
