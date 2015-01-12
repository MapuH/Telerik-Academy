using System;

class AgeAfter10Years
{
    static void Main()
    {
        Console.WriteLine("Please, enter your age:");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Your age after 10 years will be " + (age + 10));
    }
}