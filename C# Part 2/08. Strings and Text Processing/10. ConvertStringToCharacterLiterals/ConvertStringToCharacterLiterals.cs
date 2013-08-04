using System;
using System.Text;

//Write a program that converts a string to a sequence of C# Unicode character literals. Use format strings.

class ConvertStringToCharacterLiterals
{
    static void Main()
    {
        string str = "Hi!";
        byte[] unibyte = Encoding.Unicode.GetBytes(str);
        StringBuilder unistring = new StringBuilder();
        foreach (byte b in unibyte)
        {
            if (b != 0)
            {
                unistring.Append(string.Format("{0}{1}", @"\u00", b.ToString("X")));
            }
        }
        Console.WriteLine(unistring);
    }
}

