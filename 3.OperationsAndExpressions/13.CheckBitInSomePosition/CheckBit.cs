/*Problem 13. Check a Bit at Given Position
Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) in given integer number n, has value of 1.*/
using System;

class CheeckBit
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());   //integer n
        int p = int.Parse(Console.ReadLine());   //index p
        int mask = 1 << p; 
        int nAndMask = n & mask;
        int resultBit = nAndMask >> p;
        bool isOne = (resultBit == 1);
        Console.WriteLine(isOne);
    }
}

