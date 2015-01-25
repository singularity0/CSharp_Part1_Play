/*Problem 4. Number Comparer
Write a program that gets two numbers from the console and prints the greater of them.
Try to implement this without if statements.
 */
using System;
class CompareNum
{
    static void Main()
    {
        Console.WriteLine("Enter some num, any num even real ");
        double numOne = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter another num - int, real any num");
        double numTwo = double.Parse(Console.ReadLine());
        switch (numOne > numTwo)
        {
            case true: Console.WriteLine("First number {0} is bigger", numOne); break;
            case false: Console.WriteLine("Second number {0} is bigger", numTwo); break;
            default: Console.WriteLine("having fun with the program?"); break;
        }       
        //Another 'shorter' option for comparison
        //Console.WriteLine((numOne > numTwo)? "First number is bigger" : "Second number is bigger");	
        Console.WriteLine("\n\nAD:Pro version for 1$ lets you compare equal numbers on top of all existing logic!");      

    }
}


