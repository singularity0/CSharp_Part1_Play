/*Problem 14. Decimal to Binary Number

Using loops write a program that converts an integer number to its binary representation.
The input is entered as long. The output should be a variable of type string.
Do not use the built-in .NET functionality.*/ // credits: https://github.com/dechoD
using System;

class DecimalBinary
{
    static void Main()
    {
        //Console.Write("Enter a decimal num:");
        //long number = long.Parse(Console.ReadLine());

        {
            Console.Write("decimal: ");
            int number = int.Parse(Console.ReadLine());
            string binary = string.Empty;

            do
            {
                int bit = number % 2;
                number /= 2;
                binary = Convert.ToString(bit) + binary;
            }
            while (number > 1);

            binary = Convert.ToString(number) + binary;
            Console.WriteLine(binary);
        }
    }
}

