/* 
 * String Data Type
 * A sequence of characters 
 * Can contain letters, numbers, or other characters
 * Strings are immutable 
*/

using System;

class EntryPoint
{
    static void Main()
    {
        string username = "admin";

        // Indexing operation to get specific character
        // Index starts at 0 
        Console.WriteLine(username[0]);
    }
}