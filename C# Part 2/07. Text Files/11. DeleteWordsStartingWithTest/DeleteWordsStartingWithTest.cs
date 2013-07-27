using System;
using System.IO;

//Write a program that deletes from a text file all words that start with the prefix "test".
//Words contain only the symbols 0...9, a...z, A…Z, _.

class DeleteWordsStartingWithTest
{
    static void Main()
    {
        string tempFile = Path.GetTempFileName();
        StreamReader reader = new StreamReader(@"..\..\input.txt");
        StreamWriter writer = new StreamWriter(tempFile);

        using (reader)
        {
            using (writer)
            {
                string line = reader.ReadLine();
                string lineCorrected = "";
                while (line != null)
                {
                    for (int i = 0; i < line.Length; i++)
                    {
                        if ((line[i] == ' ') && (line[i + 1] == 't') && (line[i + 2] == 'e') && (line[i + 3] == 's') && (line[i + 4] == 't'))
                        {
                            i += 5;
                            while (true)
                            {
                                if (line[i] == ' ' || line[i] == ',' || line[i] == '.')
                                {
                                    break;
                                }
                                else
                                {
                                    i++;
                                }
                            }
                        }
                        lineCorrected += line[i];
                    }
                    writer.WriteLine(lineCorrected);
                    lineCorrected = "";
                    line = reader.ReadLine();
                }
            }
        }

        File.Delete(@"..\..\input.txt");
        File.Move(tempFile, @"..\..\input.txt");
    }
}

