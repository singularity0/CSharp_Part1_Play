
/*Problem 4. Print a Deck of 52 Cards

Write a program that generates and prints all possible cards from a standard deck of 52 cards (without the jokers). The cards should be printed using the classical notation (like 5 of spades, A of hearts, 9 of clubs; and K of diamonds).
The card faces should start from 2 to A.
Print each card face in its four possible suits: clubs, diamonds, hearts and spades. Use 2 nested for-loops and a switch-case statement.*/
using System;
class PrintAllCards
{
    static void Main()
    {
        string suits = "";
        string highCards = "";
        for (int i = 2; i <= 14; i++)
        {
            
            for (int j = 0; j < 4; j++)
            {
                switch (j)
                {
                    case 0: suits = "spades"; break; 
                    case 1: suits = "hearts"; break;
                    case 2: suits = "clubs"; break;
                    case 3: suits = "diamonds"; break;
                    default:break;
                }
                if (i == 11)
                {
                    highCards = "J";
                    Console.Write("{0} of {1}, ", highCards, suits); continue;
                } 
                if (i == 12)
                {
                    highCards = "Q";
                    Console.Write("{0} of {1}, ", highCards, suits); continue;
                } 
                if (i == 13)
                {
                    highCards = "K";
                    Console.Write("{0} of {1}, ", highCards, suits); continue;
                } 
                if (i == 14)
                {
                    highCards = "A";
                    Console.Write("{0} of {1}, ", highCards, suits); continue;
                } 
                Console.Write("{0} of {1}, ", i, suits);
            }
            Console.WriteLine();
        }
        //string suits = "";                //solution for printing all the cards by suit families
        //
        //for (int j = 0; j < 4; j++)
        //{
        //    if (j == 0)
        //    {
        //        suits = "spades";
        //    }
        //    if (j == 1)
        //    {
        //        suits = "diamnods";
        //    }
        //    if (j == 2)
        //    {
        //        suits = "hearts";
        //    }
        //    if (j == 3)
        //    {
        //        suits = "clubs";
        //    }
        //    for (int i = 2; i <= 14; i++)
        //    {
        //        switch (i)
        //        {                 
        //            case 2: Console.WriteLine("2 of {0}", suits); break;
        //            case 3: Console.WriteLine("3 of {0}", suits ); break;
        //            case 4: Console.WriteLine("4 of {0}", suits); break;
        //            case 5: Console.WriteLine("5 of {0}", suits); break;
        //            case 6: Console.WriteLine("6 of {0}", suits); break;
        //            case 7: Console.WriteLine("7 of {0}", suits); break;
        //            case 8: Console.WriteLine("8 of {0}", suits); break;
        //            case 9: Console.WriteLine("9 of {0}", suits); break;
        //            case 10: Console.WriteLine("10 of {0}", suits); break;
        //            case 11: Console.WriteLine("J of {0}", suits); break;
        //            case 12: Console.WriteLine("Q of {0}", suits); break;
        //            case 13: Console.WriteLine("K of {0}", suits); break;
        //            case 14: Console.WriteLine("A of {0}", suits); break;
        //            default: break;
        //        }      
        //    }
        //}  
    }
}











