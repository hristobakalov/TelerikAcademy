using System;
using System.IO;
using System.Security;

//Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini),
//reads its contents and prints it on the console. Find in MSDN how to use System.IO.File.ReadAllText(…).
//Be sure to catch all possible exceptions and print user-friendly error messages.

class ReadAndPrintContentOfAFile
{
    static void Main()
    {
        try
        {
            string path = @"C:\WINDOWS\win.ini"; //insert file path here
            //string path = Console.ReadLine();
            string readText = File.ReadAllText(path);
            Console.WriteLine(readText);
        }
        
        catch (ArgumentNullException)
        {
            Console.WriteLine("The path of the file is null!");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("The path of the file is with zero-length!");
        }
        catch (PathTooLongException)
        {
            Console.WriteLine("The name of the path is too long!");
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("The directory of the path cannot be found!");
        }
        
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("You do not have the required permission to open the file,\nor the file is read-only!");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("The file specified in path was not found!");
        }
        catch (NotSupportedException)
        {
            Console.WriteLine("Path is in invalid format!");
        }
        catch (IOException)
        {
            Console.WriteLine("An error occured while opening the file!");
        }
        catch (SecurityException)
        {
            Console.WriteLine("The caller does not have the required permission!");
        }
        
    }
}

