/*Problem 7. Sum of 5 Numbers

Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.
 */﻿

using System;

class SumOf5
{
    static void Main()
     {
        Console.WriteLine("enter nums followed by space every time");
        string[] nums = Console.ReadLine().Split(' ');
        double numOne = double.Parse(nums[0]);
        double numTwo = double.Parse(nums[1]);
        double numThree = double.Parse(nums[2]);
        double numFour = double.Parse(nums[3]);
        double numFive = double.Parse(nums[4]);
        Console.WriteLine("The sum of the first 5 numbers is: {0} ", numFive+numFour+numThree+numTwo+numOne);
  
    }

}


