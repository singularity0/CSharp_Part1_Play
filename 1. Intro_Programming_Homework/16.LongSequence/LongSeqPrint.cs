/*
Problem 16.* Print Long Sequence
Write a program that prints the first 1000 members of the sequence: 2, -3, 4, -5, 6, -7, …
You might need to learn how to use loops in C# (search in Internet).
*/ 
//disclaimer:console may not porpely show 1000 raws due limitations. 


using System;

class LongSeqPrint
{
    static void Main()
    {
        int firstSeqMemeber;
        for (firstSeqMemeber = 2; firstSeqMemeber < 1003; firstSeqMemeber++)   
        {
            if (firstSeqMemeber % 2 == 0)  // if number is even
            {
                Console.WriteLine(firstSeqMemeber);
            }
            else // i.e. if number is not even
            {
                Console.WriteLine(firstSeqMemeber * -1); // multiply by -1 and print out
            }
        }
    }
}




