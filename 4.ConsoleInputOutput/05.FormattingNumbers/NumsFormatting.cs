/*Problem 5. Formatting Numbers
Write a program that reads 3 numbers:
integer a (0 <= a <= 500)
floating-point b
floating-point c
The program then prints them in 4 virtual columns on the console. Each column should have a width of 10 characters.
The number a should be printed in hexadecimal, left aligned
Then the number a should be printed in binary form, padded with zeroes
The number b should be printed with 2 digits after the decimal point, right aligned
The number c should be printed with 3 digits after the decimal point, left aligned.*/
using System;

class NumsFormatting
{
    static void Main()
    {
        start:
        Console.WriteLine("Enter a:");
        int a = int.Parse(Console.ReadLine());
        if ((a < 0) || (a> 500))
	    {
            Console.WriteLine("Please enter a, where 0 <= a <= 500");
            goto start;
	    }
        Console.WriteLine("Enter b:");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter c:");        
        double c = double.Parse(Console.ReadLine());
        string a2 = Convert.ToString(a, 2).PadLeft(10, '0'); 
        Console.WriteLine("|{0,-0:X}|{1}|{2,10:0.00}|{3,-0:F3}|", a, a2, b, c);
    }
}

