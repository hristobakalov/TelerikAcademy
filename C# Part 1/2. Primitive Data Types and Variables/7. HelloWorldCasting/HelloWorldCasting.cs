using System;

class HelloWorldCasting
{
    static void Main()
    {
        //Declare two string variables and assign them with “Hello” and “World”.
        //Declare an object variable and assign it with the concatenation of the first two variables
        //(mind adding an interval). Declare a third string variable and initialize it with 
        //the value of the object variable (you should perform type casting).

        string hello = "Hello";
        string world = "World";
        object concatenation = hello + " " + world;
        string initialization = (string)concatenation;
        Console.WriteLine("When we use an object to concatenate the two strings we get - {0}", concatenation);
        Console.WriteLine("When we use initialization to convert an object to string we get the same thing - {0}", initialization);
    }
}

