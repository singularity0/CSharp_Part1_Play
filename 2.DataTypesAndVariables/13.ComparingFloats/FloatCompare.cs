/*Problem 13.* Comparing Floats
Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.
Note: Two floating-point numbers a and b cannot be compared directly by a == b because of the nature of the floating-point arithmetic. Therefore, we assume two numbers are equal if they are more closely to each other than a fixed constant eps.
 */
using System;
class FloatCompare
{
    static void Main()
    {
        double someNum = 4.999999;
        double otherNum = 4.999998;
        double precision = 0.000001;
        double diff = Math.Abs(someNum - otherNum);
        if (diff > precision)
        {
            Console.WriteLine(false);
            Console.WriteLine("The difference of {0} is too big", diff);
        }
        else
        {
            Console.Write(true);
            Console.WriteLine("\tNumers are equal with precision 0.000001");
        }
    }
}

