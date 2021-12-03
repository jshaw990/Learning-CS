/*
 * Escaping 
 * Reserved characters such as the \ are reserved for operations like \n 
 * C# cannot interpret its use on its own, so it must be escaped
 * This is done by using the \ twice = \\
 * You can also use the @ symbol before a string and this will allow you to use
 * reserved characters without the need to escape
*/

using System;

class EntryPoint
{
    static void Main()
    {
        string exeFile = "Word.exe";
        string pathToExe = "C:\\Program Files\\Microsoft Word\\";

        Console.WriteLine(pathToExe + exeFile);

        string pathToExe2 = @"C:\Program Files\Microsoft Word\";

        Console.WriteLine(pathToExe2 + exeFile);
    }
}