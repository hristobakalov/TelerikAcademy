using System;

class QuotedStrings
{
    static void Main()
    {
        //Declare two string variables and assign them with following value:

	    //Do the above in two different ways: with and without using quoted strings.

        string a = @"The ""use"" of quotations causes difficulties.";
        string b = "The \"use\" of quotations causes difficulties.";
        Console.WriteLine("Using quots - {0}\nWithout quots - {1}", a, b);

    }
}

