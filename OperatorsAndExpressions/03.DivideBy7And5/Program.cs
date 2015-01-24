using System;

class DivideBy7And5
{
    static void Main()
    {
        Console.WriteLine("Please, enter an integer: ");
        string input = Console.ReadLine();
        int number = Convert.ToInt32(input);
        bool divideBy7And5 = (number % 7 == 0) && (number % 5 == 0);
        Console.WriteLine(divideBy7And5);
    }
}
