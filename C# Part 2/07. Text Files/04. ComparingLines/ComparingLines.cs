using System;
using System.Collections.Generic;
using System.IO;

//Write a program that compares two text files line by line and prints the number of lines that are the same
//and the number of lines that are different. Assume the files have equal number of lines.

class ComparingLines
{
    static void Main()
    {
        StreamReader readerOne = new StreamReader("textOne.txt");
        StreamReader readerTwo = new StreamReader("textTwo.txt");

        // the file with the two text are in the project directory -> bin -> debug
        using (readerOne)
        {
            using (readerTwo)
            {
                string LineTextOne = readerOne.ReadLine();
                string LineTextTwo = readerTwo.ReadLine();
                List<int> sameLines = new List<int>();
                List<int> differentLines = new List<int>();
                int count = 1;
                while (LineTextOne != null)
                {
                    if (LineTextOne.Length != LineTextTwo.Length)
                    {
                        differentLines.Add(count);
                    }
                    else
                    {
                        bool areEqual = true;
                        for (int i = 0; i < LineTextTwo.Length; i++)
                        {
                            if (LineTextOne[i] != LineTextTwo[i])
                            {
                                areEqual = false;
                                break;
                            }
                        }
                        if (areEqual)
                        {
                            sameLines.Add(count);
                        }
                        else
                        {
                            differentLines.Add(count);
                        }
                    }
                    count++;
                    LineTextOne = readerOne.ReadLine();
                    LineTextTwo = readerTwo.ReadLine();
                    
                }

                Console.WriteLine("Lines which have same content: {0}", string.Join(" ", sameLines));
                Console.WriteLine("Lines which have different content: {0}", string.Join(" ", differentLines));
            }
        }
    }
}

