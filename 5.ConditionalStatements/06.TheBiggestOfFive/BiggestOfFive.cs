/*Problem 6. The Biggest of Five Numbers

Write a program that finds the biggest of five numbers by using only five if statements.
 */
using System;

class BiggestOfFive
{
    static void Main()
    {
        Console.WriteLine("Enter the 5 real number to check:");
        double numberOne = Double.Parse(Console.ReadLine());
        double numberTwo = Double.Parse(Console.ReadLine());
        double numberThree = Double.Parse(Console.ReadLine());
        double numberFour = Double.Parse(Console.ReadLine());
        double numberFive = Double.Parse(Console.ReadLine());
        /* Console.WriteLine("The biggest number is {0}", Math.Max(numberFive, (Math.Max(numberFour, (Math.Max(numberThree, (Math.Max(numberOne, numberTwo))))))));                                                    //----->One line solution;*/
        if ((numberOne >= numberTwo) && (numberOne >= numberThree) && (numberOne >= numberFour) && (numberOne >= numberFive))
        {
            Console.WriteLine("The biggest is {0}",numberOne);
        }
        if ((numberTwo > numberOne) && (numberTwo >= numberThree) && (numberTwo >= numberFour) && (numberTwo >= numberFive))
        {
            Console.WriteLine("The biggest is {0}",numberTwo);
        }
        if ((numberThree > numberOne) && (numberThree > numberTwo) && (numberThree >= numberFour) && (numberThree >= numberFive))
        {
            Console.WriteLine("The biggest is {0}",numberThree);
        }
        if ((numberFour > numberOne) && (numberFour > numberTwo) && (numberFour > numberThree) && (numberFour >= numberFive))
        {
            Console.WriteLine("The biggest is {0}",numberFour);
        }
        if ((numberFive > numberOne) && (numberFive > numberTwo) && (numberFive > numberThree) && (numberFive > numberFour))
        {
            Console.WriteLine("The biggest is {0}", numberFive);
        }
    }
}
