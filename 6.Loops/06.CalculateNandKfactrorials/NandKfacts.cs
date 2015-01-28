/*Problem 6. Calculate N! / K!

Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
Use only one loop.*/

using System;

class NandKfacts
{
    static void Main()
    {
        Console.WriteLine("Please enter n: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter k: ");
        int k = int.Parse(Console.ReadLine());
        int productN = 1;
        int productK = 1;

        for (int i = 1, j = 1; i <= n; i++, j++)
        {
            productN *= i;
            if (j <= k)
            {
                productK *= j;
            }
            else
            {
                continue;
            }
        }
        Console.WriteLine("n! / k! is: {0}", productN / productK);

    }
}

