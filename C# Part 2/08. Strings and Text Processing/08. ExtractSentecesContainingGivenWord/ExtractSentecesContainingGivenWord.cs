using System;
using System.Text;

//Write a program that extracts from a given text all sentences containing given word.
//Consider that the sentences are separated by "." and the words – by non-letter symbols.

class ExtractSentecesContainingGivenWord
{
    private static string ExtractSenteces(string text, string word)
    {
        StringBuilder sb = new StringBuilder();
        int indexOfWord = -1;
        do
        {
            
            indexOfWord = text.IndexOf(word, indexOfWord + 1);
            if (indexOfWord == -1)
            {
                break;
            }
            int starIndex = 0;
            for (int i = indexOfWord; i >= 0; i--)
            {
                if (text[i] == '.')
                {
                    starIndex = i + 1;
                    break;
                }
            }
            for (int i = starIndex; i < text.Length; i++)
            {
                sb.Append(text[i]);
                if (text[i] == '.')
                {
                    sb.Append("\r\n");
                    break;
                }
            }

        }
        while (indexOfWord != -1);
       
        return sb.ToString();
    }

    static void Main()
    {
        string text = "We are living in a yellow submarine.We don't have anything else.Inside the submarine is very tight.So we are drinking all the day.We will move out of it in 5 d ays.";
        Console.WriteLine(text);
        string word = " in ";
        Console.WriteLine(ExtractSenteces(text, word));
    }
}

