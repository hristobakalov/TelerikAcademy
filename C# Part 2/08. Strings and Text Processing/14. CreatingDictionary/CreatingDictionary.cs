using System;
using System.Text;

//A dictionary is stored as a sequence of text lines containing words and their explanations.
//Write a program that enters a word and translates it by using the dictionary.

class CreatingDictionary
{
    static void Main()
    {
        string[] dictionary = 
        {
            ".NET – Platform for applications from Microsoft",
            "CLR – Managed execution environment for .NET",
            "namespace – Hierarchical organization of classes"
        };
        StringBuilder sb = new StringBuilder();
        string searchedWord = Console.ReadLine();
        
        for (int i = 0; i < dictionary.Length; i++)
        {
            bool wordFound = true;
            int indexOfDash = dictionary[i].IndexOf('–') - 1;
            
            for (int k = 0; k < indexOfDash; k++)
            {
                if (searchedWord[k] != dictionary[i][k] )
                {
                    wordFound = false;
                    break;
                }
            }
            if (wordFound)
            {
                for (int k = indexOfDash + 3; k < dictionary[i].Length; k++)
                {
                    sb.Append(dictionary[i][k]);
                }
                Console.WriteLine("Definition: {0}",sb);
                return;
            }
        }
        Console.WriteLine("Your word does not exist in the dictionary!");
    }
}

