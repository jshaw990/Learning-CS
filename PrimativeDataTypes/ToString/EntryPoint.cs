/* 
 * Converting Type to String
 * Converting different data types to strings will allow you to 
 * use string method on data types which would otherwise be unavailable.
 * This is accomplished with the ToString() method.
 * If you are concatenating a different data type to a string, C# will automatically
 * do the conversion ToString for you. 
*/

using System;

class EntryPoint
{
    static void Main()
    {
        int salary = 85050;

        Console.WriteLine(salary.ToString().Contains("5"));
        Console.WriteLine(salary.ToString().IndexOf("5"));
        Console.WriteLine(salary.ToString().LastIndexOf("5"));

        string sentence = "My Salary is: ";

        string concatenated = sentence + salary;

        Console.WriteLine(concatenated);
    }
}