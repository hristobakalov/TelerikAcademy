using System;

class DancingBits
{
    static void Main()
    {
        int k = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());

        string result = "";

        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());
            result += Convert.ToString(number, 2);
        }
        char previousChar = result[0];
        int count = 1;
        int endResult = 0;
        for (int i = 1; i < result.Length; i++)
        {
            if (result[i] == previousChar)
            {
                count++;
            }
            else
            {
                if (count == k)
                {
                    endResult++;
                }
                count = 1;
                previousChar = result[i];
            }
        }
        if (count == k)
        {
            endResult++;
        }
        Console.WriteLine(endResult);
    }
}

