/*Problem 5. The Biggest of 3 Numbers

Write a program that finds the biggest of three numbers.
 */

using System;

class BiggestNumber
{
    static void Main()
    {
        Console.WriteLine("Enter the 3 real number to check:");
        double numberOne = Double.Parse(Console.ReadLine());
        double numberTwo = Double.Parse(Console.ReadLine());
        double numberThree = Double.Parse(Console.ReadLine());
        double aIndex = 0;
        double bIndex = 0;
        double cIndex = 0; 
        if (numberOne > numberTwo)
        {
            aIndex += 1;
        }
        if ((numberOne > numberThree))
	    {
            aIndex += 1;
	    }
        if (numberTwo > numberThree)
	    {
            bIndex += 1;
        } 
        if (numberTwo > numberOne)
	    {
            bIndex += 1;
	    }
        if (numberThree > numberOne)
	    {
            cIndex += 1;
        } 
        if (numberThree > numberTwo)
	    {
            cIndex += 1;
	    }
        if ((aIndex > bIndex)&&(aIndex > cIndex))
        {
            Console.WriteLine("Biggest number is {0}", numberOne);
        }
        if ((bIndex > aIndex) && (bIndex > cIndex))
        {
            Console.WriteLine("Biggest number is {0}", numberTwo);
        }
        if ((cIndex > bIndex) && (cIndex > aIndex))
        {
            Console.WriteLine("Biggest number is {0}", numberThree);
        }
        else if ((aIndex == bIndex)&&(aIndex > cIndex))
        {
            Console.WriteLine("2 Equal nums. No biggest number. Max value is {0}", numberOne);
        }
        else if ((numberOne == numberTwo) && (numberOne == numberThree))
	    {
            Console.WriteLine("We have 3 equal nums. No biggest number. Max value is {0}", numberOne);
	    }
    }
}

