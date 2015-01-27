/*Problem 9. Play with Int, Double and String

Write a program that, depending on the user’s choice, inputs an int, double or string variable.
If the variable is int or double, the program increases it by one.
If the variable is a string, the program appends * at the end.
Print the result at the console. Use switch statement.
 */
using System;

class IntDblStrPlay
{
    static void Main()
    {
        Console.WriteLine("Enter 1 for Int, 2 for double, 3 for string:");
        string selection = Console.ReadLine();
        if (selection == "1")
        {
            int intVar = int.Parse(Console.ReadLine());
            intVar += 1;
            Console.WriteLine(intVar);
        }
        else if (selection == "2")
        {
            double doubVar = double.Parse(Console.ReadLine());
            doubVar += 1;
            Console.WriteLine(doubVar);

        }
        else if (selection == "3")
        {
            string input = Console.ReadLine();
            Console.WriteLine(input + "*");
        }
        else
        {
            Console.WriteLine("No a valid choice");
        }
    }
}

