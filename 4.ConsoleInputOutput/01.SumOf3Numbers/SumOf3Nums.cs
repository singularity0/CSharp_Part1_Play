/*
 Problem 1. Sum of 3 Numbers

Write a program that reads 3 real numbers from the console and prints their sum.
 */

using System;

class SumOf3Nums
{
    static void Main()
    {
        double number, realNumberSum = 0;
        Console.WriteLine("Enter 3 numbers. 1 per line. Press enter after each input.");
        for (int i = 1; i < 4; i++)      //have used for loop to avoid writing same code 3 times for entering and storing the 3 numbers
        {
            number = double.Parse(Console.ReadLine());
            realNumberSum += number;     
        }
        Console.WriteLine("Sum is:" + realNumberSum);
    }
}

