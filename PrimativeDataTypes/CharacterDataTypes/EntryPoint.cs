/*
 * Character Data Types
 * Is to be within single quotes 
 * Can be used to output ASCII Table characters or the Unicode Table characters
 */

using System;
using System.Text; 

class EntryPoint
{
    static void Main()
    {
        char theCharacterX = 'x';
        Console.WriteLine(theCharacterX);

        // ASCII Table Characters 
        char thePlusSign = '\u002B';
        Console.WriteLine(thePlusSign);

        // Unicode Table Characters
        // Requires UTF8 Encoding

        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;

        char umlaut = '\u00F6';

        Console.WriteLine(umlaut);
    }
}
