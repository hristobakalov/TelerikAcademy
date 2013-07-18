using System;

class ThirdProblem
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int scoreLeft = 0;
        int scoreRight = 0;
        int gamesWonLeft = 0;
        int gamesWonRight = 0;
        int finalScoreLeft = 0;
        int finalScoreRight = 0;
        bool xFoundLeft = false;
        bool xFoundRight = false;
        int[] arr = { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 11, 12, 13 };
        int counterLeft = 1;
        int couterRight = 1;
        for (int i = 0; i < n * 6; i++)
        {
            string numberStr = Console.ReadLine();
            switch (numberStr)
            {
                case "A":
                    numberStr = "11";
                    break;
                case "J":
                    numberStr = "12";
                    break;
                case "Q":
                    numberStr = "13";
                    break;
                case "K":
                    numberStr = "14";
                    break;
                case "Z":
                    numberStr = "15";
                    break;
                case "Y":
                    numberStr = "16";
                    break;
                case "X":
                    numberStr = "17";
                    break;
                default:
                    break;
            }
            int numberInt = int.Parse(numberStr);



            if (counterLeft < 4)
            {
                while (counterLeft % 4 != 0)
                {
                    if (numberInt <= 14)
                    {
                        counterLeft++;
                        scoreLeft += arr[numberInt - 2];
                        break;
                    }
                    else if (numberInt == 15)
                    {
                        counterLeft++;
                        finalScoreLeft *= 2;
                        break;
                    }
                    else if (numberInt == 16)
                    {
                        counterLeft++;
                        finalScoreLeft -= 200;
                        break;
                    }
                    else if (numberInt == 17)
                    {

                        scoreRight = Int32.MinValue;
                        scoreRight = 0;
                        scoreLeft = 0;
                        couterRight = 4;
                        counterLeft = 4;
                        xFoundLeft = true;

                        break;
                    }

                }


            }
            else
            {

                while (couterRight % 4 != 0)
                {
                    if (numberInt <= 14)
                    {
                        couterRight++;
                        scoreRight += arr[numberInt - 2];
                        break;
                    }
                    else if (numberInt == 15)
                    {
                        couterRight++;
                        finalScoreRight *= 2;
                        break;
                    }
                    else if (numberInt == 16)
                    {
                        couterRight++;
                        finalScoreRight -= 200;
                        break;
                    }
                    else if (numberInt == 17)
                    {
                        

                        scoreLeft = Int32.MinValue;
                        couterRight = 4;
                        counterLeft = 4;
                        xFoundRight = true;

                        break;
                    }

                }

            }
            if ((couterRight == 4 && counterLeft == 4) && (xFoundRight && xFoundLeft))
            {
                finalScoreLeft += 50;
                finalScoreRight += 50;
                scoreLeft = 0;
                scoreRight = 0;
            }
            else if ((couterRight == 4 && counterLeft == 4) && (scoreLeft > scoreRight))
            {
                finalScoreLeft += scoreLeft;
                gamesWonLeft++;
                scoreLeft = 0;
                scoreRight = 0;
            }
            else if ((couterRight == 4 && counterLeft == 4) && (scoreRight > scoreLeft))
            {
                finalScoreRight += scoreRight;
                gamesWonRight++;
                scoreLeft = 0;
                scoreRight = 0;
            }
            else if ((couterRight == 4 && counterLeft == 4) && (scoreLeft == scoreRight))
            {
                finalScoreLeft += scoreLeft;
                scoreLeft = 0;
                scoreRight = 0;
            }
            if (couterRight == 4 && counterLeft == 4)
            {
                counterLeft = 1;
                couterRight = 1;
            }

        }

        if ((gamesWonLeft == gamesWonRight) && (finalScoreLeft > finalScoreRight))
        {
            Console.WriteLine("First player wins!");
            Console.WriteLine("Score: {0}", finalScoreLeft);
            Console.WriteLine("Games won: {0}", gamesWonLeft);
        }
        else if ((gamesWonLeft == gamesWonRight) && (finalScoreLeft < finalScoreRight))
        {
            Console.WriteLine("Second player wins!");
            Console.WriteLine("Score: {0}", finalScoreRight);
            Console.WriteLine("Games won: {0}", gamesWonRight);
        }
        else if (gamesWonLeft == gamesWonRight)
        {
            Console.WriteLine("It's a tie!");
            if (xFoundLeft == true && xFoundRight)
            {
                //finalScoreRight += 50;
                //finalScoreLeft += 50;
            }
            Console.WriteLine("Score: {0}", finalScoreLeft);
        }
        else if (xFoundLeft == true && xFoundRight == true)
        {
            Console.WriteLine("");
        }
        else if (xFoundLeft == true && xFoundRight == false)
        {
            Console.WriteLine("X card drawn! Player one wins the match!");
            //Console.WriteLine("X card drawn!");
            //Console.WriteLine("Player one wins the match!");
        }
        else if (xFoundRight == true && xFoundLeft == false)
        {
            Console.WriteLine("X card drawn! Player one wins the match!");
            //Console.WriteLine("X card drawn!");
            //Console.WriteLine("Player one wins the match!");
        }
        else if (gamesWonLeft > gamesWonRight)
        {
            Console.WriteLine("First player wins!");
            Console.WriteLine("Score: {0}", finalScoreLeft);
            Console.WriteLine("Games won: {0}", gamesWonLeft);
        }
        else if (gamesWonRight > gamesWonLeft)
        {
            Console.WriteLine("Second player wins!");
            Console.WriteLine("Score: {0}", finalScoreRight);
            Console.WriteLine("Games won: {0}", gamesWonRight);
        }

    }
}

