using System;
using System.Collections.Generic;
using System.IO;

//Write a program that removes from a text file all words listed in given another text file.
//Handle all possible exceptions in your methods.

class RemoveWordsFromFileByList
{
    private static string RemoveWord(List<string> wordsList, string line)
    {
        string result = "";
        string checkWord = "";
        for (int i = 0; i < line.Length; i++)
        {
            while (line[i] != ' ' && line[i] != ',' && line[i] != '.')
            {
                checkWord += line[i];
                i++;
            }
            bool wordExistsInList = false;
            foreach (string word in wordsList)
            {
                if (checkWord == word)
                {
                    wordExistsInList = true;
                    break;
                }
            }
            if (!wordExistsInList && checkWord != "")
            {
                result += checkWord + line[i];
            }
            
            checkWord = "";
        }
        return result;
    }

    static void Main()
    {
        try
        {
            string tempFile = Path.GetTempFileName();
            StreamReader readerText = new StreamReader(@"..\..\input.txt");
            StreamReader readerWords = new StreamReader(@"..\..\words.txt");
            StreamWriter writer = new StreamWriter(tempFile);

            List<string> wordsList = new List<string>();
            using (readerWords)
            {
                string line = readerWords.ReadLine();
                while (line != null)
                {
                    wordsList.Add(line);
                    line = readerWords.ReadLine();
                }
            }

            using (readerText)
            {
                using (writer)
                {
                    string line = readerText.ReadLine();
                    while (line != null)
                    {
                        writer.WriteLine(RemoveWord(wordsList, line));
                        line = readerText.ReadLine();
                    }

                }
            }

            File.Delete(@"..\..\input.txt");
            File.Move(tempFile, @"..\..\input.txt");
        }
        catch (FileNotFoundException exc)
        {
            Console.Error.WriteLine(
              "Can not find '{0}'!", exc.FileName);
        }
        catch (System.NullReferenceException exc)
        {
            Console.WriteLine(exc.Message);
        }
        catch
        {
            Console.WriteLine("Fatal error occurred.");
        }
    }
}

