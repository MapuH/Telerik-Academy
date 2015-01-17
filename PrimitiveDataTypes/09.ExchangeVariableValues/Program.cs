using System;

class ExchangeVariableValues
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        Console.WriteLine("Value of a is {0}, value of b is {1}", a, b);

        int c = a;
        a = b;
        b = c;
        Console.WriteLine("Value of a is {0}, value of b is {1}", a, b);
    }
}
