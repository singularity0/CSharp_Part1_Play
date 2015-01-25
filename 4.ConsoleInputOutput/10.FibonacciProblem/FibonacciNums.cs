/*Problem 10. Fibonacci Numbers

Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence (at a single line, separated by comma and space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….
Note: You may need to learn how to use loops.
 */
//reflections: I want to avoid ending the Fibonacci Sequnce with a comma. This is an aditional specification that I add :)
using System;

class FibonacciNums
{
    static void Main()
    {
        Console.WriteLine("Enter number of members n > 0 to perfrom operation on:");
        int n = int.Parse(Console.ReadLine());
        int a = 0, b = 1, sumAB = 0;
        if (n == 1)         
        {
            Console.WriteLine("Fibonacci Sequence is: {0} ", a); return;
        }
        else if (n == 2)
        {
            Console.Write("Fibonacci Sequence is: {0}, {1} \n", a, b); return;
        }
        else
        {
            Console.Write("Fibonacci Sequence is: {0}, {1}, ", a, b);
            for (int i = 0; i < n - 2; i++)       //n-2 used as we print 2 members of the sequnce(a and b) before the for cycle
            {
                sumAB = a + b;
                a = b;
                b = sumAB;
                Console.Write("{0}", sumAB);     // use Console.WriteLine("{0}, ",sumAB) if you find printing the last , is ok
                if (n - 3 > i)                   //if conditional used only to avoid the last , when printing as it is annoying.
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
        }
    }
}

