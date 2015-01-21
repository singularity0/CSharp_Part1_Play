/*Problem 3. Divide by 7 and 5
Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 at the same time.
 */
using System;
class Division7and5
{
    static void Main()
    {
        Console.WriteLine("Give me an integer");
        int whateverInt = int.Parse(Console.ReadLine());
        if ((whateverInt % 7 == 0) & (whateverInt % 5 == 0) & (whateverInt >0))  // remainder of 7 and 5 = 0 and integer is not 0
        {
            Console.WriteLine("True.Divisible to both 7 and 5");
        }
        else
        {
            Console.WriteLine("False. Number not divisible");
        }

    }
}
 
