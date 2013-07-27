using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Security;

//Write a program that reads a list of words from a file words.txt
//and finds how many times each of the words is contained in another file test.txt.
//The result should be written in the file result.txt and 
//the words should be sorted by the number of their occurrences in descending order.
//Handle all possible exceptions in your methods.

class CountContainedWords
{
    private static void CountWord(IDictionary<string,int> dictionary, string line)
    {
        string checkWord = "";
        for (int i = 0; i < line.Length; i++)
        {
            while (line[i] != ' ' && line[i] != ',' && line[i] != '.')
            {
                checkWord += line[i];
                i++;
                if (i > line.Length - 1)
                {
                    break;
                }
            }
            bool wordFound = dictionary.ContainsKey(checkWord);
            if (wordFound)
            {
                dictionary[checkWord]++;
            }

            checkWord = "";
        }
    }

    private static void PrintDictionary(IDictionary<string, int> dictionary)
    {
        StreamWriter result = new StreamWriter(@"..\..\result.txt");
        using (result)
        {
            var sortedDictionary = (from d in dictionary
                                    orderby d.Value descending
                                    select d);

            foreach (KeyValuePair<string, int> word in sortedDictionary)
            {
                result.WriteLine("Key = {0}, Value = {1}", word.Key, word.Value);
            }
        }
        
    }

    static void Main(string[] args)
    {
        try
        {
            StreamReader text = new StreamReader(@"..\..\test.txt");
            StreamReader words = new StreamReader(@"..\..\words.txt");


            IDictionary<string, int> dictionary = new SortedDictionary<string, int>();

            using (words)
            {
                string line;
                while ((line = words.ReadLine()) != null)
                {
                    dictionary.Add(line, 0);
                }
            }

            using (text)
            {
                string line = text.ReadLine();
                while (line != null)
                {
                    CountWord(dictionary, line);
                    line = text.ReadLine();
                }
            }
            PrintDictionary(dictionary);
        }
        catch (IOException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (UnauthorizedAccessException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (SecurityException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}

