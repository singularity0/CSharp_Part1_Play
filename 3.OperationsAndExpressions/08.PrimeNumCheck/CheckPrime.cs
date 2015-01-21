/*Problem 8. Prime Number Check
Write an expression that checks if given positive integer number n (n <= 100) is prime (i.e. it is divisible without remainder only to itself and 1).
Note: You should check if the number is positive
 */
using System;
class CheckPrime
{
    static void Main()
    {
        Console.WriteLine("Enter number:");
        int number = int.Parse(Console.ReadLine());
        string messageFalse = "False. Not a prime number";
        string messageTrue = "True. Prime number";
        if (number > 100)
        {
            Console.WriteLine("The number is bigger than 100. Wrong number");
        } 
        else if ((number == 1)||(number <=1))     
        {
            Console.WriteLine(messageFalse);
        }
        else if ((number == 2) || (number == 3))
        {
            Console.WriteLine(messageTrue);
        }
        else if ((number % 2 == 0) || (number % 3 == 0) || (number % 5 == 0) || (number % 7 == 0))
        {
            Console.WriteLine(messageFalse);
        }
        else 
        {
            Console.WriteLine(messageTrue);
        }
        
    }
}

