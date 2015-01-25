/*Problem 11.* Numbers in Interval Dividable by Given Number

Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that the reminder of the division by 5 is 0.*/

using System;

class InIntervalDividable
{
    static void Main()
    {
        int counter = 0;
        Console.WriteLine("Enter 2 numbers - interval start and interval end values:");
        int intOne = int.Parse(Console.ReadLine());
        int intTwo = int.Parse(Console.ReadLine());
        for (int i = intOne; i <= intTwo; i++)
        {
            if (i % 5 == 0)
            {
                counter += 1;
            }
        }
        Console.WriteLine("Then number of members p in the provided interval is: {0} \n",counter);
    }
}

