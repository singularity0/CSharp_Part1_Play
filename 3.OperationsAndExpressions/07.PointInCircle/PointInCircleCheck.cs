/*Problem 7. Point in a Circle
Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).
 */
using System;
class PointInCircleCheck
{
    static void Main()
    {
        Console.WriteLine("Eneter x value:");
        double x = double.Parse(Console.ReadLine());
        Console.WriteLine("Eneter y value:");
        double y = double.Parse(Console.ReadLine());
        bool IsInside = (x * x) + (y * y) <= 2 * 2;
        Console.WriteLine(IsInside);
    }
}

