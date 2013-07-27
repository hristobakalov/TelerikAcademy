using System;
using System.IO;

//Write a program that extracts from given XML file all the text without the tags.

class ExtractTextFromXML
{
    static void Main()
    {
        StreamReader reader = new StreamReader("input.xml");

        using (reader)
        {
            string line = reader.ReadLine();
            string text = "";
            while (line != null)
            {
                for (int i = 1; i < line.Length; i++)
                {
                    if (line[i - 1] == '>')
                    {
                        while (line[i] != '<')
                        {
                            text += line[i];
                            i++;
                        }
                        if (text != "")
                        {
                            Console.WriteLine(text);
                            text = "";
                        }
                    }
                }
                line = reader.ReadLine();
            }
        }
    }
}

