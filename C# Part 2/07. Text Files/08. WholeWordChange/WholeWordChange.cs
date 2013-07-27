using System;
using System.Diagnostics;
using System.IO;

//Modify the solution of the previous problem to replace only whole words (not substrings).

class WholeWordChange
{
    private static string Replace(string line)
    {
        string replaced = "";

        for (int i = 0; i < line.Length; i++)
        {

            if ((line[i] == 's') && (line[i + 1] == 't') && (line[i + 2] == 'a') && (line[i + 3] == 'r') &&
                (line[i + 4] == 't') && ((line[i + 5] == ' ') || (line[i + 5] == ',' || (line[i + 5] == '.'))))
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

