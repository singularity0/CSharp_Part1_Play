/*Problem 11. Bitwise: Extract Bit #3
Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
The bits are counted from right to left, starting from bit #0.
The result of the expression should be either 1 or 0.
 */
using System;
class ValueBit3
{
    static void Main()
    {
        uint number = uint.Parse(Console.ReadLine());
        uint mask = 1 << 3;
        uint numebrAndMask = number & mask;
        uint result = numebrAndMask >> 3;
        Console.WriteLine("The bit is {0}",result);
    }
}

