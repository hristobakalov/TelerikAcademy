using System;
using System.IO;

//Write a program that reads a text file and inserts line numbers in front of each of its lines.
//The result should be written to another text file.

class InsertingLineNumbers
{
    static void Main()
    {
        StreamReader reader = new StreamReader("sometext.txt");
        StreamWriter writer = new StreamWriter("textwithlines.txt");
        using (reader)
        {
            using (writer)
            {
                int lineNumber = 0;
                string line = reader.ReadLine();
                while (line != null)
                {
                    lineNumber++;
                    writer.WriteLine("Line {0}: {1}", lineNumber, line);
                    line = reader.ReadLine();
                }
                Console.WriteLine("Task completed!");
            }
        }
    }
}

