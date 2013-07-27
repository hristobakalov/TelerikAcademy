using System;
using System.Diagnostics;
using System.IO;

//Write a program that replaces all occurrences of the substring "start" with the substring "finish" in a text file.
//Ensure it will work with large files (e.g. 100 MB).

//the program works even for 200MB files, but is really slow. For 100 MB file it takes around 20 sec, for 200 MB file around 1:30 min

class ReplaceStartWithFinish
{
    private static string Replace(string line)
    {
        string replaced = "";

        for (int i = 0; i < line.Length; i++)
        {
            
            if ((line[i] == 's') && (line[i + 1] == 't') && (line[i + 2] == 'a') && (line[i + 3] == 'r') && (line[i + 4] == 't'))
            {
                replaced += "finish";
                i += 5;
            }
            replaced += line[i];
        }
        return replaced;
    }

    static void Main()
    {
        Stopwatch stopwatch = new Stopwatch();
        StreamReader reader = new StreamReader("input.txt");
        StreamWriter writer = new StreamWriter("output.txt");
        using (reader)
        {
            using (writer)
            {
                stopwatch.Start();
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    writer.WriteLine(Replace(line));
                }
                stopwatch.Stop();
                Console.WriteLine(stopwatch.Elapsed);
            }
        }
    }
}

