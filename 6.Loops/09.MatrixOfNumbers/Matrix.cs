/*Write a program that reads from the console a positive integer number n (1 = n = 20) and prints a matrix like in the examples below. Use two nested loops*/

using System;

class Matrix
{
    static void Main()
    {
        Console.WriteLine("Enter n :");
        int n = int.Parse(Console.ReadLine());
        while ((n <= 0)||(n>21))
        {
            Console.WriteLine("Enter correct n. 21>n>0:");
            n = int.Parse(Console.ReadLine());
        }
        for (int i = 1; i <= n; i++)
        {
            
            for (int j = 0; j < n; j++)
            {
                Console.Write("{0}",j+i);            
            }
            Console.WriteLine();
        }
    }
}

