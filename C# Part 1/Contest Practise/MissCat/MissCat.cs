using System;

class MissCat
{
    static void Main()
    {
        string input = Console.ReadLine();
        int n = int.Parse(input);

        int catOne = 0;
        int catTwo = 0;
        int catThree = 0;
        int catFour = 0;
        int catFive = 0;
        int catSix = 0;
        int catSeven = 0;
        int catEight = 0;
        int catNine = 0;
        int catTen = 0;

        for (int i = 0; i < n; i++)
        {
            int catNumber = int.Parse(Console.ReadLine());
            switch (catNumber)
            {
                case 1:
                    catOne++;
                    break;
                case 2:
                    catTwo++;
                    break;
                case 3:
                    catThree++;
                    break;
                case 4:
                    catFour++;
                    break;
                case 5:
                    catFive++;
                    break;
                case 6:
                    catSix++;
                    break;
                case 7:
                    catSeven++;
                    break;
                case 8:
                    catEight++;
                    break;
                case 9:
                    catNine++;
                    break;
                case 10:
                    catTen++;
                    break;
                default:
                    Console.WriteLine("Mistake!");
                    break;
            }
           
            
        }
        if (catOne >= catTwo && catOne >= catThree && catOne >= catFour && catOne >= catFive &&
               catOne >= catSix && catOne >= catSeven && catOne >= catEight && catOne >= catNine && catOne >= catTen)
        {
            Console.WriteLine("1");
        }

        else if (catTwo >= catOne && catTwo >= catThree && catTwo >= catFour && catTwo >= catFive &&
            catTwo >= catSix && catTwo >= catSeven && catTwo >= catEight && catTwo >= catNine && catTwo >= catTen)
        {
            Console.WriteLine("2");
        }

        else if (catThree >= catOne && catThree >= catTwo && catThree >= catFour && catThree >= catFive &&
            catThree >= catSix && catThree >= catSeven && catThree >= catEight && catThree >= catNine && catThree >= catTen)
        {
            Console.WriteLine("3");
        }

        else if (catFour >= catOne && catFour >= catTwo && catFour >= catThree && catFour >= catFive &&
            catFour >= catSix && catFour >= catSeven && catFour >= catEight && catFour >= catNine && catFour >= catTen)
        {
            Console.WriteLine("4");
        }

        else if (catFive >= catOne && catFive >= catTwo && catFive >= catThree && catFive >= catFour &&
            catFive >= catSix && catFive >= catSeven && catFive >= catEight && catFive >= catNine && catFive >= catTen)
        {
            Console.WriteLine("5");
        }

        else if (catSix >= catOne && catSix >= catTwo && catSix >= catThree && catSix >= catFour &&
            catSix >= catFive && catSix >= catSeven && catSix >= catEight && catSix >= catNine && catSix >= catTen)
        {
            Console.WriteLine("6");
        }

        else if (catSeven >= catOne && catSeven >= catTwo && catSeven >= catThree && catSeven >= catFour &&
            catSeven >= catFive && catSeven >= catSix && catSeven >= catEight && catSeven >= catNine && catSeven >= catTen)
        {
            Console.WriteLine("7");
        }

        else if (catEight >= catOne && catEight >= catTwo && catEight >= catThree && catEight >= catFour &&
            catEight >= catFive && catEight >= catSix && catEight >= catSeven && catEight >= catNine && catEight >= catTen)
        {
            Console.WriteLine("8");
        }

        else if (catNine >= catOne && catNine >= catTwo && catNine >= catThree && catNine >= catFour &&
            catNine >= catFive && catNine >= catSix && catNine >= catSeven && catNine >= catEight && catNine >= catTen)
        {
            Console.WriteLine("9");
        }
        else
        {
            Console.WriteLine("10");
        }
    }
}

