/*Problem 10. Point Inside a Circle & Outside of a Rectangle
Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2).
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
        bool pointInCircle = (x - 1) * (x - 1) + (y - 1) * (y - 1) <= (1.5 * 1.5);
        bool pointOutsideRect = x > 1 || x < 6 && y > -1 || y < 2;
        if (x == 0 || y == 0)
        {
            Console.WriteLine("No");
        }
        else if ((pointInCircle == true) && (pointOutsideRect == true))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
    }
}
