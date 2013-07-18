using System;
using System.Numerics;
class SecondProblem
{
    static void Main()
    {
        checked
        {


            string number = "99999999999999999999";
            //string number = Console.ReadLine();
            decimal n = decimal.Parse(number);
            decimal specialSum = 0;
            for (int i = 1; i <= number.Length; i++)
            {
                if (i % 2 == 1)
                {
                    specialSum += (n % 10) * (i * i);
                    n /= 10;
                }
                else
                {
                    specialSum += (n % 10) * (n % 10) * i;
                    n /= 10;
                }

            }
            string[] arr = { " ", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", };
            string alphaSeq = "";
            decimal length = specialSum % 10;
            decimal r = specialSum % 26;


            for (int i = 0; i < length; i++)
            {
                alphaSeq += arr[(int)r + 1];
                r++;
                if (r > 25)
                {
                    r = 0;
                }
            }
            Console.WriteLine(specialSum);

            if (length == 0)
            {
                Console.WriteLine("{0} has no secret alpha-sequence", number);
            }
            else
            {
                Console.WriteLine(alphaSeq);
            }

        }
    }
}