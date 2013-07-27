using System;
using System.Net;

//Write a program that downloads a file from Internet (e.g. http://www.devbg.org/img/Logo-BASD.jpg)
//and stores it the current directory. Find in Google how to download files in C#.
//Be sure to catch all exceptions and to free any used resources in the finally block.

class DownloadAFile
{
    static void Main()
    {
        try
        {
            string fileName = "Baby-Soldier-Funny.jpg";
            string myStringWebResource = "http://theresofunny.com/wp-content/uploads/2013/06/Baby-Soldier-Funny.jpg";

            // Create a new WebClient instance.
            WebClient myWebClient = new WebClient();


            Console.WriteLine("Downloading File \"{0}\" from \"{1}\"\n", fileName, myStringWebResource);
            // Download the Web resource and save it into the selected directory
            myWebClient.DownloadFile(myStringWebResource, fileName);
            Console.WriteLine("Successfully Downloaded File \"{0}\" from \"{1}\"", fileName, myStringWebResource);
            Console.WriteLine("\nDownloaded file saved in the projects folder in folfer bin, in debug folder!");
        }
        catch(ArgumentNullException)
        {
            Console.WriteLine("The address parametur is null!");
        }
        catch (WebException)
        {
            Console.WriteLine("The URI formed by combining BaseAddress and address is invalid, or\nFilename is null or Empty, or\nThe file does not exist, or\nAn error occurred while downloading data!");
        }
        catch (NotSupportedException)
        {
            Console.WriteLine("The method has been called simultaneously on multiple threads!");
        }
    }
}

