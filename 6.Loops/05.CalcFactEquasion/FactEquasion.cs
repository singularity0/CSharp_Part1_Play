/*Problem 5. Calculate 1 + 1!/X + 2!/X2 + … + N!/XN

Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/xn.
Use only one loop. Print the result with 5 digits after the decimal point
 */

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Please enter n:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter x:");
        int x = int.Parse(Console.ReadLine());
        double calc = 0;
        double sum = 0;
        double multiplier = 1;  

        for (int i = 1; i <= n; i++)
        {
            multiplier *= i;
            calc = multiplier / Math.Pow(x, i);
            sum += calc;
        }
        double s = sum + 1;
        Console.WriteLine("{0:F5}",s);

    }
}

