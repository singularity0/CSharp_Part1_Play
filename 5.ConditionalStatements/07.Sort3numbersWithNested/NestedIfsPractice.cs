/*Problem 7. Sort 3 Numbers with Nested Ifs

Write a program that enters 3 real numbers and prints them sorted in descending order.
Use nested if statements.
Note: Don’t use arrays and the built-in sorting functionality.*/
using System;

class NestedIfsPractice
{
    static void Main()
    {
        Console.WriteLine("Enter the 5 real number to check:");
        double a = Double.Parse(Console.ReadLine());
        double b = Double.Parse(Console.ReadLine());
        double c = Double.Parse(Console.ReadLine());
        
        if (a > b)
        {
            if (a > c)
            {
                if (b > c)
                {
                    Console.WriteLine("Numbers sorted are {0}, {1}, {2}", a, b, c);
                }
                else   //b<c
                {
                    Console.WriteLine("Numbers sorted are {0}, {1}, {2}", a, c, b);
                }
            }
            else      // a < c
            {
                Console.WriteLine("Numbers sorted are {0}, {1}, {2}", c, a, b);
            }
        }
        else if (a < b)   
        {
            if (b > c)               
            {
                if (a < c)
                {
                    Console.WriteLine("Numbers sorted are {0}, {1}, {2}", b, c, a);               
                }
                else
                {
                    Console.WriteLine("Numbers sorted are {0}, {1}, {2}", b, a, c);               
                }
            }
            else  // b < c
	            {
                    Console.WriteLine("Numbers sorted are {0}, {1}, {2}", c, b, a);               
	            }         
        }
        else if (a == b)
        {
            if (a > c)
            {
                Console.WriteLine("Numbers sorted are {0}, {1}, {2}", a, b, c);
            }
            else    //c > a
            {
                Console.WriteLine("Numbers sorted are {0}, {1}, {2}", c, a, b);               
            }
        }
        else if (a == c)
        {
            if (a > b)
            {
                Console.WriteLine("Numbers sorted are {0}, {1}, {2}", a, c, b);
            }
            else        // a < b
            {
                Console.WriteLine("Numbers sorted are {0}, {1}, {2}", b, a, c);             
            }
        }
    }
}

