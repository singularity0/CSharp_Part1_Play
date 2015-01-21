/*Problem 14. Modify a Bit at Given Position

We are given an integer number n, a bit value v (v=0 or 1) and a position p.
Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v at the position p from the binary representation of n while preserving all other bits in n.
 */
using System;

class BitPosition
{
    static void Main()
    {
        Console.WriteLine("Enter values for number n, position p, bit value v. Please press enter after each value input.\n");
        int n = int.Parse(Console.ReadLine());    
        int p = int.Parse(Console.ReadLine());
        int v = int.Parse(Console.ReadLine());
        int mask, nORmask, nAndmask;
        if (v == 1)
        {
            mask = 1 << p;
            nORmask = n | mask;
            Console.WriteLine("New number is:{0}",nORmask);
        }
        else   // (v == 0)
        {
            mask = ~(1 << p);
            nAndmask = n & mask;
            Console.WriteLine("New number is:{0}", nAndmask);
        }

    }
}

