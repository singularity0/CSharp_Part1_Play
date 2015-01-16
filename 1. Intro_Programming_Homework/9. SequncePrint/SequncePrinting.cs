/*Problem 9. Print a Sequence
Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...
*/

using System;

class SequncePrinting
{
    static void Main()
    {
        sbyte firstSeqMemeber;
        for (firstSeqMemeber = 2; firstSeqMemeber < 12; firstSeqMemeber++)
        {
            if (firstSeqMemeber % 2 == 0)  // if number is even
            {
                Console.WriteLine(firstSeqMemeber);
            }
            else // i.e. if number is not even
            {
                Console.WriteLine(firstSeqMemeber* -1); // multiply by -1 and print out

            } 
        }   
    }
}
