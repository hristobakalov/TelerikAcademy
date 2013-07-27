using System;
using System.IO;

//Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file.
//Example:
//	Ivan			George
//	Peter	->		Ivan
//	Maria			Maria
//	George			Peter

class SortingListOfStrings
{
    static void Main()
    {
        StreamReader reader = new StreamReader("input.txt");
        StreamWriter writer = new StreamWriter("output.txt");

        using (reader)
        {
            using (writer)
            {
                string inputStr = reader.ReadLine();
                string[] input = inputStr.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                Array.Sort(input);
                writer.WriteLine("{0}", string.Join(" ", input));
            }
        }
    }
}

