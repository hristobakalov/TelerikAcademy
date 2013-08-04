using System;
using System.Collections.Generic;

//Write a program that reads a string from the console and lists all different words in the string
//along with information how many times each word is found.

class CountWordsInString
{
    static void Main()
    {
        string text = Console.ReadLine();
        string[] words = text.Split(new char[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries);

        Dictionary<string, int> dictionary = new Dictionary<string, int>();

        for (int i = 0; i < words.Length; i++)
        {
            if (dictionary.ContainsKey(words[i]))
            {
                dictionary[words[i]]++;
            }
            else
            {
                dictionary.Add(words[i], 1);
            }
        }
        foreach (KeyValuePair<string, int> word in dictionary)
        {
            Console.WriteLine("Key = {0}, Value = {1}", word.Key, word.Value);
        }
    }
}

