using System;
using System.Collections.Generic;
class SubsetSum
{
    static void Main()
    {
        checked
        {
            //long s = long.Parse(Console.ReadLine());
            //long n = long.Parse(Console.ReadLine());

            //long[] numbers = new long[n];

            //for (int i = 0; i < n; i++)
            //{
            //    numbers[i] = long.Parse(Console.ReadLine());
            //}

            //int sumCounter = 0;
            //int combinations = (int)Math.Pow(2, n);

            //for (int i = 1; i < combinations; i++)
            //{
            //    long tempSum = 0;
            //    for (int j = 0; j < n; j++)
            //    {
            //        int mask = 1 << j;
            //        int iAndMask = mask & i;
            //        int bit = iAndMask >> j;

            //        if (bit == 1)
            //        {
            //            tempSum += numbers[j];
            //        }
            //    }
            //    if (tempSum == s)
            //    {
            //        sumCounter++;
            //    }
            //}
            //Console.WriteLine(sumCounter);


            // second solution !!

            long s = long.Parse(Console.ReadLine());
            long n = long.Parse(Console.ReadLine());

            long[] numbers = new long[n];

            for (int i = 0; i < n; i++)
            {
                numbers[i] = long.Parse(Console.ReadLine());
            }

            List<long> sums = new List<long>();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0, len = sums.Count; j < len; j++)
                {
                    sums.Add(sums[j] + numbers[i]);
                }
                sums.Add(numbers[i]);
            }
            //Console.WriteLine(string.Join(", ", sums));

            int counter = 0;
            for (int i = 0; i < sums.Count; i++)
            {
                if (s == sums[i])
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}

