/*
Problem 8. Isosceles Triangle

Write a program that prints an isosceles triangle of 9 copyright symbols ©, something like this:
   ©

  © ©

 ©   ©

© © © ©
Note: The © symbol may be displayed incorrectly at the console so you may need to change the console character encoding to UTF-8 and assign a Unicode-friendly font in the console.

Note: Under old versions of Windows the © symbol may still be displayed incorrectly, regardless of how much effort you put to fix it.
 */

using System;
using System.Text;

class IsoTriangle
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        char copyright = '\u00A9';
        string firstElement = new String(' ',3);     // same as "   "
        string secondElement = new String(' ',7);
        string thirdElement = new String(' ', 2);
        string frourthElement = new String(' ', 1); 
        Console.WriteLine("{0}{1}{2}",firstElement, copyright, firstElement);
        Console.WriteLine(secondElement);
        Console.WriteLine("{0}{1}{2}{3}{4}", thirdElement, copyright, frourthElement, copyright, thirdElement);
        Console.WriteLine(secondElement);
        Console.WriteLine("{0}{1}{2}{3}{4}", frourthElement, copyright, firstElement, copyright, frourthElement);
        Console.WriteLine(secondElement);
        Console.WriteLine("{0}{1}{0}{1}{0}{1}{0}", copyright, frourthElement);
    }
}

