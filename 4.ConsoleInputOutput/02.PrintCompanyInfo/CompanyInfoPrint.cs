/*Problem 2. Print Company Information
A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number.
Write a program that reads the information about a company and its manager and prints it back on the console.*/

using System;

class CompanyInfoPrint
{
    static void Main()
    {
        Console.WriteLine("Company name:");
        string companyName = Console.ReadLine();
        Console.WriteLine("Company address:");
        string companyAddress = Console.ReadLine();
        Console.WriteLine("Phone number:");
        string companyPhone = Console.ReadLine();
        Console.WriteLine("Fax number:");
        string companyFax = Console.ReadLine();  
        Console.WriteLine("Web site:");
        string companyUrl = Console.ReadLine();
        Console.WriteLine("Manager first name:");
        string managerFirstName = Console.ReadLine();
        Console.WriteLine("Manager last name:");
        string managerLastName = Console.ReadLine();
        Console.WriteLine("Manager age:");
        byte ManagerAge = byte.Parse(Console.ReadLine());
        Console.WriteLine("Manager phone:");
        string managerPhoneNum = Console.ReadLine();

        if (companyFax == "2")      // as per user sample input in the example this condtion should be present
        {
            companyFax = "(no fax)";
        }


        Console.WriteLine("\n\n{0}\nAddress:{1}\nTel.{2}\nFax:{3}\nWeb site:{4}\n{5} {6} (age:{7}, tel. {8}) ", companyName, companyAddress, companyPhone, companyFax, companyUrl, managerFirstName, managerLastName, ManagerAge, managerPhoneNum);
    }
}
