using System;

class ReadAgeFromConsole
{
    static void Main()
    {
        Console.WriteLine("Write down your age please!");
        int age = int.Parse(Console.ReadLine()); // Console.Readline - reads the text which you write in and keeps it as a string; int.Parse converts the string into integer.
        Console.WriteLine("After 10 years you will be - {0} years old.", age + 10); // Age + 10 goes on the place of -> {0}
    }
}

