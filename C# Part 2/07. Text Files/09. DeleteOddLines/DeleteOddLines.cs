using System;
using System.IO;

/// <summary> // i have no idea how I did this :O 
/// Write a program that deletes from given text file all odd lines. The result should be in the same file.
/// </summary>
class DeleteOddLines
{
    static void Main()
    {
        string tempFile = Path.GetTempFileName();
        StreamReader reader = new StreamReader("input.txt");
        StreamWriter writer = new StreamWriter(tempFile);

        using (reader)
        {
            using (writer)
            {
                string line;
                int counter = 1;
                while ((line = reader.ReadLine()) != null)
                {
                    if (counter % 2 == 0)
                    {
                        writer.WriteLine(line);
                    }
                    counter++;
                }
            }
        }

        File.Delete("input.txt");
        File.Move(tempFile, "input.txt");
    }
}

