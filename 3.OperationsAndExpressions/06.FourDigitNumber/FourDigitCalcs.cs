/*Problem 6. Four-Digit Number
Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
Prints on the console the number in reversed order: dcba (in our example 1102).
Puts the last digit in the first position: dabc (in our example 1201).
Exchanges the second and the third digits: acbd (in our example 2101).
The number has always exactly 4 digits and cannot start with 0.
 */
using System;
class FourDigitCalcs
{
    static void Main()
    {
        Console.WriteLine("Enter a number");
        int inputNum = int.Parse(Console.ReadLine());
        int firstDiv = inputNum % 10;                   //with this first division we get the fourth digit
        int secondDiv = (inputNum / 10) % 10;           //with this second division we get the third digit
        int thirdDiv = (inputNum / 100) % 10;           //the fourth digit
        int fourhtDiv = (inputNum/1000) % 10;           //the first digit
        int sum = firstDiv + secondDiv + thirdDiv + fourhtDiv;
        Console.WriteLine("sum of the digits of the number {0} is {1}+{2}+{3}+{4}={5}\n",inputNum,fourhtDiv,thirdDiv,secondDiv,firstDiv,sum);
        Console.WriteLine("the number {0} in reversed order is {1}{2}{3}{4}\n", inputNum,firstDiv, secondDiv,thirdDiv,fourhtDiv);
        Console.WriteLine("Last digit on 1st position for the number {0}-->{1}{2}{3}{4}\n", inputNum, firstDiv, fourhtDiv, thirdDiv, secondDiv);
        Console.WriteLine("Second and third digit exchange for the number {0}-->{1}{2}{3}{4}", inputNum, fourhtDiv,secondDiv, thirdDiv, firstDiv);

    }
}

