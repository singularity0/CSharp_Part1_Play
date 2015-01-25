/*
 Problem 8. Numbers from 1 to n

Write a program that reads an integer number n from the console and prints all the numbers in the interval [1..n], each on a single line.
Note: You may need to use a for-loop.
 */

using System;

class Nums1ToN
{
    static void Main()
    {
        Console.WriteLine("Enter number n:");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("The numbers [1 .. n] are:");
        for (int i = 1; i <= number; i++)
        {
            Console.WriteLine(i);
        }
    }
}

