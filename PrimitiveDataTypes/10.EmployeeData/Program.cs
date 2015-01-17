using System;

class EmployeeData
{
    static void Main()
    {
        string firstName = "Denzel";
        string lastName = "Washington";
        byte age = 35;
        char gender = 'm';
        string idNumber = "8306112507";
        string uniqueNumber = "27561234";

        /* Used string data type for the last 2 characteristics as these are
         * personal numbers related to the employee, they are not to be used
         * as actual numbers which participate in math operations or similar. */

        Console.WriteLine("First name: {0}", firstName);
        Console.WriteLine("Last name: {0}", lastName);
        Console.WriteLine("Age: {0}", age);
        Console.WriteLine("Gender: {0}", gender);
        Console.WriteLine("ID number: {0}", idNumber);
        Console.WriteLine("Unique employee number: {0}", uniqueNumber);
    }
}