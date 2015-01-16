/*
 Problem 6. Strings and Objects

Declare two string variables and assign them with Hello and World.
Declare an object variable and assign it with the concatenation of the first two variables (mind adding an interval between).
Declare a third string variable and initialize it with the value of the object variable (you should perform type casting).
*/
using System;

class StringObejects
{
    static void Main(string[] args)
    {
        string hello = "Hello";
        string world = "World";
        object helloWorldVar = hello + " " + world;
        string combineString = (string)helloWorldVar;  //casting. same as string combineString = Convert.ToString(helloWorldVar); 
        Console.WriteLine(combineString);
    }
}

