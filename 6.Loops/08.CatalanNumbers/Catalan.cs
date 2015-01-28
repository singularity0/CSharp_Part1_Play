/*In combinatorics, the Catalan numbers are calculated by the following formula: catalan-formula
Write a program to calculate the nth Catalan number by given n (1 < n < 100).*/

using System;
using System.Numerics;

class Catalan
{
    static void Main()
    {
        Console.WriteLine("Please enter n:");
        int n = int.Parse(Console.ReadLine());
        while ((n<=1)||(n>=100))
        {
            Console.WriteLine("Please enter n: again. N should be (1 < n < 100)");
            n = int.Parse(Console.ReadLine());
        }
        BigInteger product2n = 1;
        BigInteger productN = 1;
        BigInteger productNPlus1 = 1;

        for (int i = 1; i <= 2*n; i++)
        {
            product2n *= i;
        }
        for (int i = 1; i <= n; i++)
        {
            productN *= i;
        }
        for (int i = 1; i <= n+1; i++)
        {
            productNPlus1 *= i;
        }        
        Console.WriteLine("Catalan(n) = {0} ", product2n / (productNPlus1 * productN));

    }
}

