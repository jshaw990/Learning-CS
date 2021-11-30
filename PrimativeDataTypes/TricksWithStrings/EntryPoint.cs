/* 
 * Tricks while working with Strings
*/

using System;

class EntryPoint
{
    static void Main()
    {
        // Will generate a string with the dash repeating 40 times
        string separator = new string('-', 40);

        string fruitJuice = "Apple juice";

        // Checks to see if character exists
        // Does not tell number of times
        // Is case sensitive
        Console.WriteLine(fruitJuice.Contains("f"));
        Console.WriteLine(separator);

        Console.WriteLine(fruitJuice.Contains("j"));
        Console.WriteLine(separator);

        // Will output the index of the first instance of the character
        Console.WriteLine(fruitJuice.IndexOf("p"));

        Console.WriteLine(separator);

        // Will output the index of the last instance of the character
        Console.WriteLine(fruitJuice.LastIndexOf("p"));

        Console.WriteLine(separator);

        // Can be used to find whole words as well
        Console.WriteLine(fruitJuice.Contains("juice"));
        Console.WriteLine(fruitJuice.IndexOf("juice"));
        Console.WriteLine(fruitJuice.LastIndexOf("juice"));

        Console.WriteLine(separator);

        // Multiple operations within one line
        bool containsApple = fruitJuice.ToLower().Contains("apple");
        Console.WriteLine(containsApple);

        Console.WriteLine(separator);

        fruitJuice = fruitJuice.ToLower();
        Console.WriteLine(fruitJuice);
    }
}