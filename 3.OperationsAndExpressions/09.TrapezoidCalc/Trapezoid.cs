/*Problem 9. Trapezoids
Write an expression that calculates trapezoid's area by given sides a and b and height h.
 */
using System;

class Trapezoid
{
    static void Main()
    {
        Console.WriteLine("Enter values for a, b and h. Press enter after each value input.");
        float a = float.Parse(Console.ReadLine());
        float b = float.Parse(Console.ReadLine());
        float h = float.Parse(Console.ReadLine());
        float trapezoidArea = ((a + b)/2)*h;
        Console.WriteLine("The area of the trapezoid is: {0}", trapezoidArea);
        Console.WriteLine("|a\t|b\t|h\t|area\t|\n|{0}\t|{1}\t|{2}\t|{3}\t|",a,b,h,trapezoidArea);  //values representaiton as table
    }
}

