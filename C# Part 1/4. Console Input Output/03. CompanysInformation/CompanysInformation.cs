using System;

class CompanysInformation
{
    static void Main()
    {
        //A company has name, address, phone number, fax number, web site and manager.
        //The manager has first name, last name, age and a phone number. 
        //Write a program that reads the information about a company and its manager and prints them on the console.

        Console.Write("Insert the NAME of the company - ");
        string companyName = Console.ReadLine();

        Console.Write("Insert the ADDRESS of the company - ");
        string companyAddress = Console.ReadLine();

        Console.Write("Insert the PHONE NUMBER of the company - ");
        long companyPhoneNumber = long.Parse(Console.ReadLine());

        Console.Write("Insert the FAX NUMBER of the company - ");
        long companyFaxNumber = long.Parse(Console.ReadLine());

        Console.Write("Insert the WEB SITE of the company - ");
        string companyWebSite = Console.ReadLine();

        Console.Write("\nInsert the FIRST NAME of the manager - ");
        string managerFirstName = Console.ReadLine();

        Console.Write("Insert the LAST NAME of the manager - ");
        string managerLastName = Console.ReadLine();

        Console.Write("Insert the AGE of the manager - ");
        byte managerAge = byte.Parse(Console.ReadLine());

        Console.Write("Insert the PHONE NUMBER of the manager - ");
        long managerPhoneNumber = long.Parse(Console.ReadLine());

        Console.WriteLine("\n\nThe name of your company is {0},\nIts address is {1},\nIts phone number is {2},\nIts fax number is {3},\nIt has a website - {4}", companyName, companyAddress, companyPhoneNumber, companyFaxNumber, companyWebSite);
        Console.WriteLine("The name of the manager is {0}" , (managerFirstName + " " + managerLastName));
        Console.WriteLine("He is {0} years old and his phone number is - {1}", managerAge, managerPhoneNumber);
    }
}

