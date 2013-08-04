using System;
using System.Text;

//You are given a text. Write a program that changes the text in all regions surrounded by the tags
//<upcase> and </upcase> to uppercase. The tags cannot be nested. 

class ChangeSurroundedTextToUpperCase
{
    static void Main()
    {
        string text = "We are living in a <upcase>yellow submarine</upcase>.\nWe don't have <upcase>anything</upcase> else.";
        Console.WriteLine("Text before the change:");
        Console.WriteLine(text);
        string result = ConvertToUpper(text);
        Console.WriteLine("Text after the change:");
        Console.WriteLine(result);
    }

    private static string ConvertToUpper(string text)
    {
        StringBuilder sb = new StringBuilder();
        StringBuilder wordToUpper = new StringBuilder();
        int indexBegin = -1;
        int indexEnd = -1;
        int startToPrintFrom = 0;
        do
        {
            indexBegin = text.IndexOf("<upcase>", indexBegin + 1);
            indexEnd = text.IndexOf("</upcase>", indexEnd + 1);
            
            if (indexEnd != -1 && indexBegin != -1)
            {
                for (int i = startToPrintFrom; i < indexBegin; i++)
                {
                    sb.Append(text[i]);
                }
                for (int i = indexBegin + 8; i < indexEnd; i++)
                {
                    wordToUpper.Append(text[i]);
                }
                string result = (wordToUpper.ToString()).ToUpper();
                sb.Append(result);
                wordToUpper.Clear();
                startToPrintFrom = indexEnd + 9;
            }
            else
            {
                for (int i = text.LastIndexOf("</upcase>") + 9; i < text.Length; i++)
                {
                    sb.Append(text[i]);
                }
            }
        }
        while (indexBegin != -1 && indexEnd != -1);
        
        return sb.ToString();
    }
}

