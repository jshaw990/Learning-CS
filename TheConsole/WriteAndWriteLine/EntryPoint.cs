/*
 * Write & WriteLine
 * Console.Write puts the cursor on the same line
 * Console.WriteLine will create a new line for the write
 * You can use \n within either of the two to create a new line
*/

using System;

class EntryPoint
{
    static void Main()
    {
        Console.Write("I am learning C#");
        Console.Write(" and really");
        Console.Write(" enjoying it!");

        Console.WriteLine("-----");

        Console.WriteLine("I am learning C#");
        Console.WriteLine("and really");
        Console.WriteLine("enjoying it!");

        Console.WriteLine("-----");

        Console.Write("I am learning C#\n");
        Console.Write("and really");
        Console.Write(" enjoying it!");

        Console.WriteLine("-----");

        // Visual Studio will allow you to improve the readability by
        // splitting the code into multiple lines
        Console.Write("I am learning C#" +
            "\nand really" +
            "\nenjoying it!");
    }
}