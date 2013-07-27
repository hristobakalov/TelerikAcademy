using System;

class PrintMembersOfASequence
{
    static void Main()
    {
        for (int i = 2; i < 12; i++) // this is a cycle which goes through the numbers from 2 to 11
        {
            if (i % 2 == 0) // checks if 2 devides i without a remainder
            {
                Console.WriteLine(i); // if it is devided without a remainder it prints i
            }
            else
            {
                Console.WriteLine(-i); // if there the remainder is 1 than it prints -i
            }
        }
    }
}

