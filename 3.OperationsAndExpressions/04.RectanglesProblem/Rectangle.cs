/*Problem 4. Rectangles
Write an expression that calculates rectangle’s perimeter and area by given width and height.
 */
using System;

class Rectangle
{
    static void Main()
    {
        Console.WriteLine("Enter the width");
        decimal width = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Enter the height");
        decimal height = decimal.Parse(Console.ReadLine());
        decimal perimeter = (width*2) + (height*2);
        decimal area = height * width;
        Console.WriteLine("width|height|perimeter|area \n {0}\t{1}\t{2}\t{3}", width, height, perimeter, area); 
    }
}

