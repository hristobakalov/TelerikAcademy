using System;

class DeclareCharacterVariable
{
    static void Main()
    {
        //Declare a character variable and assign it with the symbol that has Unicode code 72.
        //Hint: first use the Windows Calculator to find the hexadecimal representation of 72.

        char number = '\u0048';
        Console.WriteLine("The character represantation of 72 is - {0}", number);
    }
}

