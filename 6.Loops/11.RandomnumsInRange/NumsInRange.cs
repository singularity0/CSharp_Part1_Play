/*Problem 11. Random Numbers in Given Range

Write a program that enters 3 integers n, min and max (min = max) and prints n random numbers in the range [min...max].
 */

using System;


class NumsInRange
{
    static void Main()
    {
        Console.WriteLine("Enter n:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter min:");
        int min = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter max:");
        int max = int.Parse(Console.ReadLine());
        Random rnd = new Random();

        for (int i = 1; i <= n; i++)
        {
            int number = rnd.Next(min, max);
            Console.Write(number );
        }
        Console.WriteLine();
    }
}

