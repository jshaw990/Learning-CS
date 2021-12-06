/*
 * Formatting the Console
 * There are various ways to format the console and space characters to line up
 * {0, 10} will move 10 characters to the right with placeholders
 * {varName, 10} will move 10 characters to the right with interpolation
 * {0/varName, 10:C5} to move and add currency rounding to 5 digits
 * {0/varName:C5} to add currency rounding of 5 digits 
*/

using System;

class EntryPoint
{
    static void Main()
    {
        string fruit = "apple";
        string juice = "juice";

        Console.WriteLine("{0, 10}", fruit);
        Console.WriteLine("{0, 10}", juice);

        Console.WriteLine($"{fruit, 15}");
        Console.WriteLine($"{juice, 15}");

        float money = 10000.5666f;
        Console.WriteLine($"{money, 15:C}");

        float proteinDayOne = 80.888555f;
        float proteinDayTwo = 85.564f;
        float proteinDayThree = 65.432f;
        float proteinDayFour = 88.9033212f;
        float proteinDayFive = 95.65656f;
        float proteinDaySix = 76.321f;
        float proteinDaySeven = 91.0121f;

        float total = proteinDayOne + proteinDayTwo + proteinDayThree + proteinDayFour + proteinDayFive + proteinDaySix + proteinDaySeven;
        string proteinIntake = "Protein Intake Week: 1";
        string separator = new string('=', proteinIntake.Length);

        Console.WriteLine(separator);
        Console.Write("|");
        Console.Write(proteinIntake);
        Console.Write("|\n");
        Console.Write("|");
        Console.Write(separator);
        Console.Write("|\n");
        Console.Write("|");
        Console.Write($"{proteinDayOne, 22}");
        Console.Write("|\n");
        Console.Write("|");
        Console.Write($"{proteinDayTwo, 22}");
        Console.Write("|\n");
        Console.Write("|");
        Console.Write($"{proteinDayThree, 22}");
        Console.Write("|\n");
        Console.Write("|");
        Console.Write($"{proteinDayFour, 22}");
        Console.Write("|\n");
        Console.Write("|");
        Console.Write($"{proteinDayFive, 22}");
        Console.Write("|\n");
        Console.Write("|");
        Console.Write($"{proteinDaySix, 22}");
        Console.Write("|\n");
        Console.Write("|");
        Console.Write($"{proteinDaySeven, 22}");
        Console.Write("|\n");
        Console.Write("|");
        Console.Write(separator);
        Console.Write("|\n");
        Console.Write("|");
        Console.Write($"Total: {total, 15}");
        Console.Write("|\n");
    }
}