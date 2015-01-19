/*Problem 15.* Age after 10 Years

Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.
*/

using System;

class AgeAfter10Years
{
    static void Main()
    {
        int birthInt, birthMonthInt, birthYearInt, yearValueToInt, monthValueToInt, dayValueToInt;
        string birthdate, birthMonth, birthYear, yearValue, monthValue, dayValue;
        Console.WriteLine("Enter your birth date (numbers only allowed)");
        birthdate = Console.ReadLine();
        birthInt = Convert.ToInt32(birthdate);   //value of borth date is converted to Int 
        if (birthInt > 31 || birthInt < 1)       //cheking for correctly entered date.month has 31 days at most   
        {
            Console.WriteLine("Wrong birth date. You must be joking. Hahaha. No worries. Go on");
        }
        Console.WriteLine("Enter your birth month(numbers only allowed)");
        birthMonth = Console.ReadLine();                    //birth month read from console
        birthMonthInt = Convert.ToInt32(birthMonth);        //birth month converted to Int
        if (birthMonthInt > 12 || birthMonthInt < 1)        //birth month check. yesr has 12 months at most
        {
            Console.WriteLine("Wrong birth month. You must be joking. Hahaha. No worries. Go on");
        }
        Console.WriteLine("Enter your birth year(numbers only allowed)");
        birthYear = Console.ReadLine();                        //year read from console
        birthYearInt = Convert.ToInt32(birthYear);              //year to Int
        if (birthYearInt < 1915 || birthYearInt > 2100)    //check.assuming user is < 100years old and program will live 85 year at most
        {
            Console.WriteLine("Wrong birth year. You must be joking. Hahaha. No worries. Cannot calculate based on that joke");
        }
        else if (birthYearInt > 2005 && birthYearInt < 2015)  //condition for age between 1 and 10
        {
            Console.WriteLine("quite impressive that you can code at that age.Pls try again");
        }
        else
        {
            monthValue = DateTime.Now.ToString("MM");           //month read from console and converted to string
            dayValue = DateTime.Now.ToString("dd");             //day read from console and converted to string
            yearValue = DateTime.Now.ToString("yyyy");          //year read from console and converted to string
            monthValueToInt = Convert.ToInt32(monthValue);      // month converted to Int
            dayValueToInt = Convert.ToInt32(dayValue);
            yearValueToInt = Convert.ToInt32(yearValue);
            if (monthValueToInt < birthMonthInt)            //checking if user had a birthday already 
            {           
                Console.WriteLine("You are now {0}. You haven't had a birthday this year yet. You may plan a big party", yearValueToInt - birthYearInt-1);
                Console.WriteLine("In 10 years you will be {0}", (yearValueToInt - birthYearInt) + 10 - 1 );
            }
            else
            {
                Console.WriteLine("You are now {0}. You had a birthday this year. Hope you liked your gifts.", yearValueToInt - birthYearInt);
                Console.WriteLine("In 10 years you will be {0}", (yearValueToInt - birthYearInt) + 10);
            }
        }
    }
}

