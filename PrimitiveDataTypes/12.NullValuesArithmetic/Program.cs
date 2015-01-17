using System;

class NullValuesArithmetic
{
    static void Main()
    {
        int? a = null;
        double? b = null;
        b = 3.14;

        Console.WriteLine(a);
        Console.WriteLine(b);
    }
}