/*
Problem 7. Quotes in Strings

Declare two string variables and assign them with following value: The "use" of quotations causes difficulties.
Do the above in two different ways - with and without using quoted strings.
Print the variables to ensure that their value was correctly defined.
*/

using System;

class QuotesStrings
{
    static void Main()
    {
        string firstVar = "The \"use\" of quotations causes difficulties.";     //first option using "
        string secondVar = @"The ""use"" of quotations causes difficulties.";      // second option using @
        Console.WriteLine("{0}\n{1}",firstVar, secondVar);
    }
}

