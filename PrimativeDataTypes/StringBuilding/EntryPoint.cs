/*
 * String Building
 * String concatenation can become complicated and long when using large amounts of data.
 * You can use placeholders to concatenate a string by using .Format() and having variables following your string.
 * The variable is inserted into the string using the index.
 * String interpolation can also be used by proceeding the string with the dollar sign and curly braces to denote the variables.  
*/

using System;

class EntryPoint
{
    static void Main()
    {
        string nameOfPerson = "Tim";
        string spellName = "Fireball";
        int damageTaken = 100;

        // Using placeholders 
        string damageReport = string.Format("The {0} character took {1} damage from {2}", nameOfPerson, damageTaken, spellName);

        Console.WriteLine(damageReport);

        // String interpolation
        string damageReportv2 = $"The {nameOfPerson} character took {damageTaken} damage from {spellName}";
        Console.WriteLine(damageReportv2);
    }
}