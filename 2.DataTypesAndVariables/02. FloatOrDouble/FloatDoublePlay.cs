/*Problem 2. Float or Double?

Which of the following values can be assigned to a variable of type float and which to a variable of type double: 34.567839023, 12.345, 8923.1234857, 3456.091?
Write a program to assign the numbers in variables and print them to ensure no precision is lost.
*/

using System;

class FloatDoublePlay
{
    static void Main()
    {    
        double valueOne = 34.567839023d;
        float valueTwo = 12.345f;
        double valueThree = 8923.1234857d;
        float valueFour = 3456.091f;
        Console.WriteLine("Inital values are: 34.567839023, 12.345, 8923.1234857, 3456.091");
        Console.WriteLine("Assinged values are {0}, {1}, {2}, {3}", valueOne, valueTwo, valueThree, valueFour);

    }
}

