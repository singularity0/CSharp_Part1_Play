/*Problem 1. Odd or Even Integers
Write an expression that checks if given integer is odd or even.
 */

using System;
class OddEven
{
    static void Main()
    {
        Console.WriteLine("hey user, enter some number with the numpad please");
        string oddOrEvenNumber = Console.ReadLine();
        int oddOrEvenNumberToInt = int.Parse(oddOrEvenNumber);
        Console.WriteLine(oddOrEvenNumberToInt % 2 == 0 ? "The number is even" : "The number is odd" );
    }
}

