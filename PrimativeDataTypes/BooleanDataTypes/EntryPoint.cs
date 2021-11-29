/*
 * Boolean data types can only have two values
 * True or False
 * They are used to describe the state of an object
 * Such as: isCupFull = false
 * Or they are the result of a comparison operation
 * Such as: is 1 greater than (>) 2
*/

using System;

class EntryPoint
{
    static void Main()
    {
        bool isCupFull = false;

        bool isOneBiggerThanTwo = 1 > 2;

        bool isOneSmallerThanTwo = 1 < 2;

        Console.WriteLine(isCupFull);
        Console.WriteLine(isOneBiggerThanTwo);
        Console.WriteLine(isOneSmallerThanTwo);
    }
}