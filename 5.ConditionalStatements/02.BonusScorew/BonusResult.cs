/*Problem 2. Bonus Score

Write a program that applies bonus score to given score in the range [1…9] by the following rules:
If the score is between 1 and 3, the program multiplies it by 10.
If the score is between 4 and 6, the program multiplies it by 100.
If the score is between 7 and 9, the program multiplies it by 1000.
If the score is 0 or more than 9, the program prints “invalid score”.
 */
using System;

class BonusResult
{
    static void Main()
    {
        Console.WriteLine("What is the score you want onus applied to:");
        int score = int.Parse(Console.ReadLine());
        switch (score)
        {
            case 1: score *= 10; Console.WriteLine("The score with added bonus is {0}", score); break;
            case 2: score *= 10; Console.WriteLine("The score with added bonus is {0}", score); break;
            case 3: score *= 10; Console.WriteLine("The score with added bonus is {0}", score); break;
            case 4: score *= 100; Console.WriteLine("The score with added bonus is {0}", score); break;
            case 5: score *= 100; Console.WriteLine("The score with added bonus is {0}", score); break;
            case 6: score *= 100; Console.WriteLine("The score with added bonus is {0}", score); break;
            case 7: score *= 1000; Console.WriteLine("The score with added bonus is {0}", score); break;
            case 8: score *= 1000; Console.WriteLine("The score with added bonus is {0}", score); break;
            case 9: score *= 1000; Console.WriteLine("The score with added bonus is {0}", score); break;

            default: Console.WriteLine("Invalid score"); break;
        }
        //if ((1<=score)&&(score<=3))               //another solution without switch case operator
        //{
        //    score *= 10;
        //    Console.WriteLine("The score with added bonus is {0}", score);
        //}
        //else if ((4 <= score) && (score <= 6))
        //{
        //    score *= 100;
        //    Console.WriteLine("The score with added bonus is {0}", score);
        //
        //}
        //else if ((7 <= score) && (score <= 9))
        //{
        //    score *= 1000;
        //    Console.WriteLine("The score with added bonus is {0}", score);
        //
        //}
        //else    //  covering the case of n < 0  and n > 9
        //{
        //    Console.WriteLine("Invalid score");
        //}
    }
}

