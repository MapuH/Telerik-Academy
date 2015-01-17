using System;

class StringsAndObjects
{
    static void Main()
    {
        string word1 = "Hello";
        string word2 = "World";
        object together = word1 + " " + word2;
        string cast = (string)together;

        Console.WriteLine(cast);
    }
}
