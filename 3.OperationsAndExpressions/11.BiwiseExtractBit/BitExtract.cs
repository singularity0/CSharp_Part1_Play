/*
 Problem 11. Bitwise: Extract Bit #3

Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
The bits are counted from right to left, starting from bit #0.
The result of the expression should be either 1 or 0.
 */
using System;

class BitExtract
{
    static void Main()
    {
        //string number = Console.ReadLine();
        //uint castedNumeber = Convert.ToInt32(number);
        //Console.WriteLine(castedNumeber);
        int varNum = int.Parse(Console.ReadLine());
        int number = int.Parse(Console.ReadLine());
        int mask = 1 << varNum; Console.WriteLine(mask);
        int IntAndmask = number  & mask;
        int bit = IntAndmask >> varNum;
        Console.WriteLine(bit);

    }
}

