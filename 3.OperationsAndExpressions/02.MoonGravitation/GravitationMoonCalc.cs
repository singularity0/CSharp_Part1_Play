/*Problem 2. Gravitation on the Moon
The gravitational field of the Moon is approximately 17% of that on the Earth.
Write a program that calculates the weight of a man on the moon by a given weight on the Earth.
*/
using System;
class GravitationMoonCalc
{
    static void Main()
    {
        Console.WriteLine("Enter men wight");
        float manWeight = float.Parse(Console.ReadLine());       
        Console.WriteLine("Same wight of the same man on the moon would be -- {0}", manWeight * 0.17);
    }
}

