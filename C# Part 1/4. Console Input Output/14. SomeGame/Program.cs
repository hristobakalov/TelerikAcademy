using System;

class Program
{
    static void Main()
    {
        char c = 'c';
        char h = 'h';
        char a = 'a';
        char m = 'm';
        char p = 'p';
        char i = 'i';
        char o = 'o';
        char n = 'n';

        char hiddenChar = '_';

        bool isCShowen = false;
        bool isHShowen = false;
        bool isAShowen = false;
        bool isMShowen = false;
        bool isPShowen = false;
        bool isIShowen = false;
        bool isOShowen = false;
        bool isNShowen = false;

        int livesCount = 9;
        Console.Write("Enter command:");
        string command = Console.ReadLine();

        while (true)
        {
            if (command == "view")
            {
                Console.WriteLine("Your lives are {0}", livesCount);
            }
            if (command == "guess")
            {
                char letter = (char)Console.Read();
                if (letter == c && !isCShowen)
                {
                    isCShowen = true;
                }
                if (letter == c && isCShowen)
                {
                    Console.WriteLine("You have already revealed this letter");
                }

                if (letter == h && !isHShowen)
                {
                    isHShowen = true;
                }
                if (letter == h && isHShowen)
                {
                    Console.WriteLine("You have already revealed this letter");
                }

                if (letter == a && !isAShowen)
                {
                    isAShowen = true;
                }
                if (letter == a && isAShowen)
                {
                    Console.WriteLine("You have already revealed this letter");
                }

                if (letter == m && !isMShowen)
                {
                    isMShowen = true;
                }
                if (letter == m && isMShowen)
                {
                    Console.WriteLine("You have already revealed this letter");
                }

                if (letter == p && !isPShowen)
                {
                    isPShowen = true;
                }
                if (letter == p && isPShowen)
                {
                    Console.WriteLine("You have already revealed this letter");
                }

                if (letter == i && !isIShowen)
                {
                    isIShowen = true;
                }
                if (letter == i && isIShowen)
                {
                    Console.WriteLine("You have already revealed this letter");
                }

                if (letter == o && !isOShowen)
                {
                    isOShowen = true;
                }
                if (letter == o && isOShowen)
                {
                    Console.WriteLine("You have already revealed this letter");
                }

                if (letter == n && !isNShowen)
                {
                    isNShowen = true;
                }
                if (letter == n && isNShowen)
                {
                    Console.WriteLine("You have already revealed this letter");
                }

                if (letter != c && letter != h && letter != a && letter != m && letter != p && letter != i && letter != o && letter != n)
                {
                    livesCount--;
                }
                if (livesCount == 0)
                {
                    Console.WriteLine("Game over!");
                    break;
                }

            }
            Console.Write("Enter command: ");
            command = Console.ReadLine();
        }
    }
}

