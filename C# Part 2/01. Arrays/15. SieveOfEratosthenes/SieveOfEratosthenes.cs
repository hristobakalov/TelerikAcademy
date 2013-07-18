using System;
using System.Collections.Generic;

class SieveOfEratosthenes
{
    static void Main()
    {
        //Write a program that finds all prime numbers in the range [1...10 000 000].
        //Use the sieve of Eratosthenes algorithm (find it in Wikipedia).

        List<int> numbers = new List<int>();

        const int max = 10000000;

        for (int i = 1; i <= max; i++)
        {
            numbers.Add(i); // adds this 10 000 000 in the list
        }

        int counter = 2;
        int CurrentNumber = 2;

        while ((CurrentNumber*CurrentNumber) < max) // we have to check the numbers until the current number is smaller than the biggest number
        {
            while ((counter * CurrentNumber) <= max)// checks if we have reached the biggest number 
            {
                numbers[(counter * CurrentNumber) - 1] = 0; // makes the current number 0 if it is not prime
                counter++;
            }
            if (numbers[CurrentNumber] == 0 ) // this makes sure we don't try with numbers like 4, 6, 8 ... which we have already crossed
            {
                CurrentNumber += 2;
            }
            else
            {
                CurrentNumber++;
            }
            
            counter = 2;
        }

        for (int i = 1; i < numbers.Count; i++)
        {
            if (numbers[i] != 0)
            {
                Console.Write(numbers[i] + " "); // prints the prime numbers
            }
        }

    }
}

