/*Problem 3. Min, Max, Sum and Average of N Numbers

Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
The output is like in the examples below.
 */

using System;

class MinMaxAvSum
{
    static void Main()
    {
        Console.WriteLine("How many nuber do you want to compare?");
        int n = int.Parse(Console.ReadLine());
        int min = int.MaxValue;
        int max = int.MinValue;
        int sum = 0;
        double average;
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter number: ");
            int m = int.Parse(Console.ReadLine());
            sum += m;
           
            if (m < min)
            {
                min = m;
            }
            if (max < m)
            {
                max = m;
            }
        }  
        average = (double)sum / n;
        Console.WriteLine("The min is: {0} ", min);
        Console.WriteLine("The max is: {0} ", max);
        Console.WriteLine("The sum is {0} ", sum);
        Console.WriteLine("The average is  {0:F2} ",  average);
    }
}

