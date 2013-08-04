using System;
using System.Text;

//Write a program that encodes and decodes a string using given encryption key (cipher).
//The key consists of a sequence of characters. The encoding/decoding is done by performing XOR (exclusive or)
//operation over the first letter of the string with the first of the key, the second – with the second, etc.
//When the last key character is reached, the next is the first.

class EncodingAndDecodingString
{
    private static string Encrypt(string input, string cipher)
    {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < input.Length; i++)
        {
            sb.Append((char)(input[i] ^ cipher[i % cipher.Length]));
        }
        return sb.ToString();
    }

    private static string Decrypt(string input, string cipher)
    {
        return Encrypt(input,cipher);
    }

    static void Main()
    {
        Console.Write("Insert word to encode:");
        string inputStr = Console.ReadLine();
        Console.Write("Insert key:");
        string cipher = Console.ReadLine();
        
        Console.WriteLine(Decrypt(Encrypt(inputStr, cipher), cipher));
    }
}

