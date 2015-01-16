/*Problem 14.* Current Date and Time

Create a console application that prints the current date and time. Find out how in Internet.
*/ 

using System;

class DateTimeNoww
{
    static void Main()
    {
        Console.WriteLine("Current date and time in the format MM/DD/YYYY is {0}", DateTimeOffset.Now);
    }

}

