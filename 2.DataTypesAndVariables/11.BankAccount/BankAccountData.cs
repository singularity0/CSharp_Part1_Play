/*
 Problem 11. Bank Account Data

A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account.
Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.
*/
using System;
 
class BankAccountData
{
    static void Main()
    {
        string accountHolder = "Homer Bender Jetson";
        decimal balance = 123567.77m;
        string bankName = "Moon East West North Bank";
        string iban = "BG35RBB2223333343222233";  
        ulong cardFirst = 56445455564565;
        ulong cardSecond = 43465365467543;
        ulong cardThird = 43324355555666;
        //Console.WriteLine("\n{0}\n{1}\n{2}\n{3}\n{4}\n{5}\n{6}", accountHolder, balance, bankName, iban, cardFirst, cardSecond, cardThird);
    }
}

