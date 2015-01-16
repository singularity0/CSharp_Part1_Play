﻿/*Problem 14.* Print the ASCII Table
Find online more information about ASCII (American Standard Code for Information Interchange) and write a program that prints the entire ASCII table of characters on the console (characters from 0 to 255).
Note: Some characters have a special purpose and will not be displayed as expected. You may skip them or display them differently.
Note: You may need to use for-loops (learn in Internet how)
*/
using System;
using System.Text;
class ASCIIprint
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;  
        for (int i = 0; i < 256; i++)
        {
            char c = Convert.ToChar(i);
            Console.WriteLine("|Dec value:{0}|Char Value: {1}|", i, c);
            
        }
    }
}

