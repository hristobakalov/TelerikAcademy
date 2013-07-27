using System;
using System.Collections.Generic;

namespace _11.AddingPolynomials
{
    class AddingPolynomials
    {
        //Write a method that adds two polynomials. Represent them as arrays of their coefficients as in the example below:
		//x2 + 5 = 1x2 + 0x + 5  501

        static List<int> SumPolynomials(List<int> arrFirst, List<int> arrSecond)
        {
            if (arrSecond.Count > arrFirst.Count)
            {
                List<int> temp = new List<int>();
                temp = arrFirst;
                arrFirst = arrSecond;
                arrSecond = temp;
            }

            for (int i = 0; i < arrSecond.Count; i++)
            {
                arrFirst[i] = arrFirst[i] + arrSecond[i];
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
            for (int i = arr.Count - 1; i >= 0; i--)
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
            Console.WriteLine();

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
            for (int i = arrSecond.Count - 1; i >= 0; i--)
            {
                if (i != 0 && arrSecond[i] != 0)
                {
                    Console.Write(arrSecond[i] + "*(x^" + i + ") + ");
                }
                else if (i == 0)
                {
                    Console.Write(arrSecond[i]);
                }

            }
            Console.WriteLine();

            List<int> summedUp = new List<int>();
            summedUp = SumPolynomials(arr, arrSecond);

            Console.Write("The two polynomials summed up :\n");
            for (int i = summedUp.Count - 1; i >= 0; i--)
            {
                if (i != 0 && summedUp[i] != 0)
                {
                    Console.Write(summedUp[i] + "*(x^" + i + ") + ");
                }
                else if (i == 0)
                {
                    Console.Write(summedUp[i]);
                }

            }
            Console.WriteLine();
        }
    }
}
