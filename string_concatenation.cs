using System;

class Program
{
    static void Main()
    {
        // ... Create a new string reference.
        //     It points to the literal.
        string s1 = "string2";

        // ... Add another string to the start.
        string s2 = "string1" + s1;
        Console.WriteLine(s2);
    }
}
