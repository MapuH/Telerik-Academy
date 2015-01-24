using System;

class OddOrEvenIntegers
{
    static void Main()
    {
        Console.WriteLine("Please, enter an integer: ");
        string input = Console.ReadLine();
        int number = Convert.ToInt32(input);

        if (number % 2 != 0)
        {
            Console.WriteLine("The number {0} is odd.", number);
        }
        else
        {
            Console.WriteLine("The number {0} is even.", number);
        }
    }
}
