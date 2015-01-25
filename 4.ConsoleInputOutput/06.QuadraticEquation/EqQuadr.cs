/*Problem 6. Quadratic Equation
Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).*/
/*reflections: x = [ -b +/- sqrt(b^2 - 4ac) ] / 2a
We have to find the value of (b*b - 4*a*c). 
When it is greater than Zero, we will get two Real Solutions.
When it is equal to zero, we will get one Real Solution.
When it is less than Zero, we will get two Imaginary Solutions. - No real roots.
*/
using System;

class EqQuadr
{
    static void Main()
    {
        Console.WriteLine("Enter a,b,c. Press enter after every input.");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double x1, x2, x;
        double underRoot = Math.Pow(b, 2) - 4 * a * c;
        if (underRoot > 0)
        {
            x1 = (-b +  Math.Sqrt(underRoot) ) / (2 * a) ;
            x2 = (-b -  Math.Sqrt(underRoot) ) / (2 * a) ;
            Console.WriteLine("Two real solution: x1 = {0} and x2 = {1}", x1, x2);
            
        }

        else if (underRoot == 0)
        {
            x = - b / (2*a);
            Console.WriteLine("One real solution x1 = x2= {0}", x);
        }

        else if (underRoot < 0)
        {
            underRoot = Math.Abs(underRoot);
            x1 = (-b + Math.Sqrt(underRoot)) / (2 * a);
            x2 = (-b - Math.Sqrt(underRoot)) / (2 * a);
            //Console.WriteLine("Two imaginary solutions x1 = {0} and x2 = {1}",x1,x2);
            Console.WriteLine("No real roots");
        }
    }
}

