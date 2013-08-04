using System;
using System.Text;

//Write a program that extracts from given HTML file its title (if available), and its body text without the HTML tags.

class ExtractTextFromHTMLCode
{
    private static string ExtractTitle(string text)
    {
        StringBuilder title = new StringBuilder();
        int indexBegin = text.IndexOf("<title>") + 7;
        int indexEnd = text.IndexOf("</title>");
        for (int i = indexBegin; i < indexEnd; i++)
        {
            title.Append(text[i]);
        }
        if (title.Length == 0)
        {
            return "There is no title!";
        }
        return title.ToString();
    }

    private static string ExtractBodyText(string text)
    {
        StringBuilder sb = new StringBuilder();
        int beginBody = text.IndexOf("<body>");
        int endBody = text.IndexOf("</body>");
        int index = 0;
        while (index != -1)
        {
            index = text.IndexOf('>', beginBody);
            int counter = 1;
            if (index >= endBody)
            {
                break;
            }
            bool hasWrittenAnything = false;
            while (text[index + counter] != '<')
            {
                hasWrittenAnything = true;
                sb.Append(text[index + counter]);
                counter++;
            }
            if (hasWrittenAnything)
            {
                sb.Append(Environment.NewLine);
            }
            beginBody = index + 1;
        }
        
        return sb.ToString();
    }

    static void Main()
    {
        string htmlCode = "<html><head><title>News</title></head><body><p><a href=\"http://academy.telerik.com\">TelerikAcademy</a>aims to provide free real-world practicaltraining for young people who want to turn intoskillful .NET software engineers.</p></body></html>";
        Console.WriteLine("Title: {0}",ExtractTitle(htmlCode));
        Console.WriteLine("\r\nBody Text:");
        Console.WriteLine(ExtractBodyText(htmlCode));
    }
}

