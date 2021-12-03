/* 
 * Converting, Parsing, and Typecasting
 * Typecasting the types of the two variables must be compatable 
 * Coverting vs Parsing if the data is null converting will return a 0 while parsing will throw an exception (error) 
*/

using System;

class EntryPoint
{
    static void Main()
    {
        int number = 5;
        string word = "number";
        char x = 'x';
        float pi = 3.14f;

        // Typecasting
        float interger = number;

        // int floating = pi;
        // C# will not allow this ^^ to happen due to loss of information

        int floating = (int)pi;
        // The operation above will be converted successfully, but there will still be a loss of data
        Console.WriteLine(floating);
        // A float will ALWAYS be ROUNDED DOWN to the nearest interger

        // Converting
        string stringToInt = "5";
        int stringedInt = Convert.ToInt32(stringToInt);
        Console.WriteLine(stringedInt);

        // Parsing
        int parsedString = int.Parse(stringToInt);
        Console.WriteLine(parsedString);
    }
}