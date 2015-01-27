/*Problem 4. Multiplication Sign

Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
Use a sequence of if operators.
 */
using System;

class ShowSign
{
    static void Main()
    {
        Console.WriteLine("Enter the 3 number to check:");
        double numberOne = Double.Parse(Console.ReadLine());
        double numberTwo = Double.Parse(Console.ReadLine());
        double numberThree = Double.Parse(Console.ReadLine());
        double product = 0;
        if ((numberOne == 0) || (numberTwo == 0) || (numberThree == 0))
        {
            Console.WriteLine("The product is 0");
        }
        else
        {
            if (numberOne < 0)
            {
                product += 1;
            }
            if (numberTwo < 0)
            {
                product += 1;
            }
            if (numberThree < 0)
            {
                product += 1;
            }
            if ((product == 1) || (product == 3))
            {
                Console.WriteLine("The product is - ");
            }
            else
            {
                Console.WriteLine("Th product is + ");
            }
        }
    }
}

