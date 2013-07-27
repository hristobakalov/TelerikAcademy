using System;

class ASCIITable
{
    static void Main()
    {
        //Find online more information about ASCII (American Standard Code for Information Interchange) 
        //and write a program that prints the entire ASCII table of characters on the console.

        char a = '\u0040';
        for (int i = 0; i < 255; i++)
        {
            a++;
            Console.WriteLine(a);
        }
    }
}

