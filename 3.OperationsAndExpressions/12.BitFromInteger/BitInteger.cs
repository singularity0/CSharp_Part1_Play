/*Problem 12. Extract Bit from Integer
Write an expression that extracts from given integer n the value of given bit at index p.
 */
using System;
class BitInteger
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());   //integer n
        int p = int.Parse(Console.ReadLine());   //index p
        int mask = 1 << p; 
        int nAndMask = n & mask;
        int resultBit = nAndMask >> p;
        Console.WriteLine(resultBit);    
    }
}

