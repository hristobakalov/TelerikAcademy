using System;

//Write a program that replaces in a HTML document given as string all the tags <a href="…">…</a>
//with corresponding tags [URL=…]…/URL].

class ReplaceHTMLTags
{
    private static string ReplaceTags(string text)
    {
        text = text.Replace(@"<a href=""","[URL=");
        text = text.Replace(@""">", "]");
        text = text.Replace("</a>", "[/URL]");
        return text;
    }

    static void Main()
    {
        string htmlCode = @"<p>Please visit <a href=""http://academy.telerik.com"">our site</a> to choose a training course. Also visit <a href=""www.devbg.org"">our forum</a> to discuss the courses.</p>";
        Console.WriteLine("HTML code before refactoring:\n{0}",htmlCode);
        Console.WriteLine("\nHTML code after refactoring:\n{0}", ReplaceTags(htmlCode));
    }
}

