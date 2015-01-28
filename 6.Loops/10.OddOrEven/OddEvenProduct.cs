/*Problem 10. Odd and Even Product

You are given n integers (given in a single line, separated by a space).
Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
Elements are counted from 1 to n, so the first element is odd, the second is even, etc.
 */
using System;

class OddEvenProduct
{
    static void Main()
    {
        Console.WriteLine("Enter how many integer do you want to calculate for");
        int n = int.Parse(Console.ReadLine());
        int productOdd = 1;
        int productEven = 1;
        int counter = 0;
        

        for (int i = 1; i <=n; i++)
        {
            Console.WriteLine("Enter number:{0} ", i);
            int m = int.Parse(Console.ReadLine());
            counter += 1;
            if (counter%2 == 0)  // even
            {
                productEven *= m;
            }
            else //odd
            {
                productOdd *= m;
            }
        }
        Console.WriteLine("Product of odds is {0}", productOdd);
        Console.WriteLine("Product of evens is {0}", productEven);
        if (productOdd == productEven)
        {
            Console.WriteLine("\t\t\t yes. equal\n\n");
        }
        else
        {
            Console.WriteLine("\t\t\t no. not equal\n\n");
        }













    }
}

