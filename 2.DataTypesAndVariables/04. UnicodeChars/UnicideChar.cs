/*Problem 4. Unicode Character

Declare a character variable and assign it with the symbol that has Unicode code 42 (decimal) using the \u00XX syntax, and then print it.
Hint: first, use the Windows Calculator to find the hexadecimal representation of 42. The output should be *.
*/

using System;

class UnicideChar
{
    static void Main()
    {
        char VarChar = '\u002A';
        Console.WriteLine("The char is {0} \nIt correspond to the number in Decimal system {1}. But what is the question?", VarChar, Convert.ToInt32(VarChar));
    }
        
}

