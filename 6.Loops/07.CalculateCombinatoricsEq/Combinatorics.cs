/*Calculate N! / (K! * (N-K)!)
Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). Try to use only two loops.
*/

using System;
using System.Numerics;

class Combinatorics
{
    static void Main()
    {
        Console.WriteLine("Please enter n: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter k: ");
        int k = int.Parse(Console.ReadLine());
        BigInteger productN = 1;
        BigInteger productK = 1;
        int diffNK = n - k;
        BigInteger productNK = 1;

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
        for (int i = 1; i <= diffNK; i++)
        {
            productNK *= i;
        }
        Console.WriteLine("n! / (k! * (n-k)!) = {0}", productN / (productK * productNK));
    }
}

