/*Problem 9. Sum of n Numbers

Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum. Note: You may need to use a for-loop.
*/

using System;

class SumNumsN
{
    static void Main()
    {
        Console.WriteLine("Enter number of members n to perfrom operation on:");
        int n = int.Parse(Console.ReadLine());
        double sum = 0;
        for (int i = 1; i <= n; i++)
        {
            double member = double.Parse(Console.ReadLine());
            sum += member;
        }
        Console.WriteLine("The sum of al the entered values is: {0}", sum);
    }
}

