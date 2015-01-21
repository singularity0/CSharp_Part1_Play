/*Problem 5. Third Digit is 7?
Write an expression that checks for given integer if its third digit from right-to-left is 7
 */
using System;
class Digit7
{
    static void Main()
    {
        Console.WriteLine("Enter the integer number");
        int someNum = int.Parse(Console.ReadLine());
        int dividedBy100 = someNum / 100;
        int dividedby10 = dividedBy100 % 10;
        Console.WriteLine(dividedby10 == 7 ?"True. You have a 3rd digit right-to left = 7" : "False. 3rd digit right-to left is not 7. Play again?");
    }
}

