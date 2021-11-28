/*
 * Floating Point Numbers
 * Floats can hold number to a precision of up to 7 places
 * Floats consist of four elements of the variable
 * type, name, payload, and suffix
 * 
*/

using System;

class EntryPoint
{
    static void Main()
    {
        float someFloat1 = 3.14f;

        Console.WriteLine(someFloat1);

        float floatMin = float.MinValue;
        float floatMax = float.MaxValue;

        Console.WriteLine("Minimum Value: " + floatMin);
        Console.WriteLine("Maximum Value: " + floatMax);

        float someFloat2 = 3.1454545454f;

        Console.WriteLine(someFloat2);
        // Only six decimal places will be shown with the rest cutoff

        float someFloat3 = 323123131231232323232323232.434f;

        Console.WriteLine(someFloat3);
        // Still only the first seven digits are shown
        // The remaining values are cut off

        Console.WriteLine(someFloat3.ToString("f"));

        // Calculate are of a circle
        float radius = 5f;
        float pi = 3.141592f;
        float areaOfCircle = pi * radius * radius;

        Console.WriteLine(areaOfCircle);
        // >> 78.5398

        // Double has a maximum memory type of 128 bites
        // This is very low precision
        double doubleMin = double.MinValue;
        double doubleMax = double.MaxValue;

        Console.WriteLine("Minimum Value: " + doubleMin);
        Console.WriteLine("Maximum Value: " + doubleMax);

        // Decimal has a very high precision in comparison to a double
        decimal decimalMin = decimal.MinValue;
        decimal decimalMax = decimal.MaxValue;

        Console.WriteLine("Minimum Value: " + decimalMin);
        Console.WriteLine("Maximum Value: " + decimalMax);
    }
}
