/*
 Problem 12. Null Values Arithmetic
Create a program that assigns null values to an integer and to a double variable.
Try to print these variables at the console.
Try to add some number or the null literal to these variables and print the result.
*/
using System;

class NullValuesCalc
{
    static void Main()
    {
        int? intValue = null;
        double? doubleValue = null;
        Console.WriteLine("{0}\n{1}",intValue, doubleValue);
        intValue = +1;
        doubleValue = 13.1219;
        Console.WriteLine("\t{0}\t{1}",intValue, doubleValue);
    }
}

