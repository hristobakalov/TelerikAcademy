using System;

class CalculateSumFloat
{
    static void Main()
    {
        //Write a program to calculate the sum (with accuracy of 0.001): 1 + 1/2 - 1/3 + 1/4 - 1/5 + ...
        float number = 2.0f;
        float sum = 1.0f;
        float temp = 0.0f;
        float tempSum = 0.0f;

        do
        {
            tempSum = sum;
            if (number % 2 == 0)
            {
                temp = 1 / number;
            }
            else
            {
                temp = -1 / number;
            }
            sum = sum + temp;
            number++;

        } while (tempSum != sum);
        Console.WriteLine("The sum of the numbers is : {0:0.000}", sum); 
    }
}

