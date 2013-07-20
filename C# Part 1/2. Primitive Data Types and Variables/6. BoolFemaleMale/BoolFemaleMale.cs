using System;

class BoolFemaleMale
{
    static void Main()
    {
        //Declare a boolean variable called isFemale and assign an appropriate value corresponding to your gender.

        Console.WriteLine("Please write down TRUE if you are a female and FALSE if you are a man!");
        bool isFemale = bool.Parse(Console.ReadLine());
        if (isFemale == true)
        {
            Console.WriteLine("You are truely a female!");
        }
        else
        {
            Console.WriteLine("You are a brave man! Go drink a beer!");
        }
    }
}

