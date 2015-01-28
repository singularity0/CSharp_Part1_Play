/*Problem 13. Binary to Decimal Number
Using loops write a program that converts a binary integer number to its decimal form.
The input is entered as string. The output should be a variable of type long.
Do not use the built-in .NET functionality.   // // credits: https://github.com/dechoD
 */
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a binary num: ");
        string binary = Console.ReadLine();
        int iterations = binary.Length;
        int decimalNumber = 0;

        for (int i = 0; i < iterations; i++)
        {
            int index = binary.Length - 1;
            string bit = binary.Substring(index, 1);
            decimalNumber += (int.Parse(bit)) * ((int)Math.Pow(2, i));
            binary = binary.Substring(0, binary.Length - 1);
        }

        Console.WriteLine(decimalNumber);
    }
}