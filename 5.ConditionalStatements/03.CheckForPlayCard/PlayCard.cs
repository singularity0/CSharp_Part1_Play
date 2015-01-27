/*Problem 3. Check for a Play Card

Classical play cards use the following signs to designate the card face: `2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A. Write a program that enters a string and prints “yes” if it is a valid card sign or “no” otherwise. 
*/ 
using System;
class PlayCard
{
    static void Main()
    {
        Console.WriteLine("Enter value f card to check");
        string valueToCheck = Console.ReadLine();
        int number;
        if (int.TryParse(valueToCheck, out number))
        {
            if ((number > 1)&&(number<11))
            {
                 Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
        else if (((valueToCheck == "J") || (valueToCheck == "Q") || (valueToCheck == "K") || (valueToCheck == "A")))
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }    
    }
}

