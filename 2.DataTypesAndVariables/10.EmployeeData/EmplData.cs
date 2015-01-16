/*
 Problem 10. Employee Data

A marketing company wants to keep record of its employees. Each record would have the following characteristics:
First name
Last name
Age (0...100)
Gender (m or f)
Personal ID number (e.g. 8306112507)
Unique employee number (27560000…27569999)
Declare the variables needed to keep the information for a single employee using appropriate primitive data types. Use descriptive names. Print the data at the console.
 */
using System;

class EmplData
{
    static void Main()
    {
        string firstName = "Homer";
        string lastName = "Simpson";
        byte age = 42;
        char gender = 'm';
        long personalIdNumber = 8306112507;  
        int UID = 27569999;
        Console.WriteLine("User full data is:\n{0}\n{1}\n{2}\n{3}\n{4}\n{5}", firstName, lastName, age, gender,personalIdNumber, UID);
    }
}

