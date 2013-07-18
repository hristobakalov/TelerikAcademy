using System;
using System.Collections.Generic;

class LettersInAWord
{
    static void Main()
    {
        //Write a program that creates an array containing all letters from the alphabet (A-Z).
        //Read a word from the console and print the index of each of its letters in the array.

        List<char> letters = new List<char>();
        char a = '\u0041';
        //fulfill the list
        for (int i = 0; i < 25; i++)
        {
            Console.Write(a + " ");
            letters.Add(a);
            a++;
        }
        Console.WriteLine();

        Console.WriteLine("Insert a word!");
        string userWord = Console.ReadLine();
        userWord = userWord.ToUpper(); //the word can be both with small and big letters, after that it is convert to upperCase

        //goes through every element of the word and checks on which position is this letter in the array
        for (int i = 0; i < userWord.Length; i++)
        {
            for (int j = 0; j < letters.Count; j++)
            {
                if (userWord[i] == letters[j])
                {
                    Console.Write(j + " ");
                }
            }
        }
        Console.WriteLine();
    }
}

