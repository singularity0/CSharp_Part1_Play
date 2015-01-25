/*Problem 3. Circle Perimeter and Area

Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point.*/

using System;

class CircleAreaPerimeter
{
    static void Main()
    {
        
        Console.WriteLine("Enter Radius r:");
        double radius = double.Parse(Console.ReadLine());
        double area = Math.PI * radius * radius;
        double perimeter = 2 * Math.PI * radius;
        Console.WriteLine("Select 1 for Area, 2 for Perimeter");
        int selection = int.Parse(Console.ReadLine());

        switch (selection)
        {
            case 1: Console.WriteLine("Area is: {0:0.00} ", area );break;
            case 2: Console.WriteLine("Perimeter is: {0:F2} ", perimeter); break;
            default: Console.WriteLine("Wrong selection."); break;
        }

    }
}

