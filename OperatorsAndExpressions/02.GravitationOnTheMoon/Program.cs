using System;

class GravityOnTheMoon
{
    static void Main()
    {
        Console.WriteLine("Please, enter your weight: ");
        string input = Console.ReadLine();
        double weightOnTheMoon = Convert.ToDouble(input) * 0.17;
        Console.WriteLine("Your weight on the Moon will be {0}.", weightOnTheMoon);
    }
}
