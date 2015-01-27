/*Problem 1. Exchange If Greater

Write an if-statement that takes two double variables a and b and exchanges their values if the first one is greater than the second one. As a result print the values a and b, separated by a space.
 */
using System;

class IfGreater
{
    static void Main()
    {
        Console.WriteLine("Enter Variables a and b");
        double a = Double.Parse(Console.ReadLine());
        double b = Double.Parse(Console.ReadLine());
        double c;
        if (a>b)
        {
            c = a;  
            a = b;
            b = c;
            Console.WriteLine("{0} {1}", a,b);  // First one is bigger, hence values are exchanged
        }
        else  // First one is samller, hence values are not exchanged                        
        {
            Console.WriteLine("{0} {1}", a,b);  
        }
    }
}

