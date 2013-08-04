using System;
using System.Text;

//Write a program that parses an URL address given in the format:
//[protocol]://[server]/[resource]
//and extracts from it the [protocol], [server] and [resource] elements.
//For example from the URL http://www.devbg.org/forum/index.php the following information should be extracted:
//		[protocol] = "http"
//		[server] = "www.devbg.org"
//		[resource] = "/forum/index.php"

class ExtractingInformationFromURL
{
    static void Main()
    {
        StringBuilder protocol = new StringBuilder();
        StringBuilder server = new StringBuilder();
        StringBuilder resource = new StringBuilder();
        Console.Write("Enter URL:");
        string url = Console.ReadLine();
        int indexOfStart = 0;
        for (int i = indexOfStart; i < url.Length; i++)
        {
            if (url[i] == ':')
            {
                indexOfStart = i + 3;
                break;
            }
            protocol.Append(url[i]);
        }
        for (int i = indexOfStart; i < url.Length; i++)
        {
            if (url[i] == '/')
            {
                indexOfStart = i;
                break;
            }
            server.Append(url[i]);
        }
        for (int i = indexOfStart; i < url.Length; i++)
        {
            resource.Append(url[i]);
        }
        Console.WriteLine("[protocol] = {0}", protocol);
        Console.WriteLine("[server] = {0}", server);
        Console.WriteLine("[resource] = {0}", resource);
    }
}

