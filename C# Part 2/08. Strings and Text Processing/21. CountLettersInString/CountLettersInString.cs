using System;
using System.Collections.Generic;

//Write a program that reads a string from the console and prints all different letters
//in the string along with information how many times each letter is found. 

class CountLettersInString
{
    static void Main()
    {
        string text = "pesho eats bob";

        Dictionary<char, int> dictionary = new Dictionary<char, int>();

        for (int i = 0; i < text.Length; i++)
        {
            if (dictionary.ContainsKey(text[i]))
            {
                dictionary[text[i]]++;
            }
            else
            {
                dictionary.Add(text[i], 1);
            }
        }
        foreach (KeyValuePair<char, int> word in dictionary)
        {
            Console.WriteLine("Key = {0}, Value = {1}", word.Key, word.Value);
        }
    }
}

