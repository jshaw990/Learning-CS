/* 
 * Array Data Type
 * Collection of data
 * Can contain any of the different data types 
 * Strings within string arrays are immutable 
 * Can index values within the array with:
 * fruits[2]
 * And can index specific characters from that value with a second index: 
 * fruits[2][1]
 */

using System;

class EntryPoint
{
    static void Main()
    {
        int[] numbers = { 5, 10, 8, 6, 1, 22, 3 };
        Console.WriteLine(numbers[3]);

        int[] numbers2 = new int[5];

        numbers2[0] = 3;
        numbers2[1] = 20;
        numbers2[2] = 100;
        numbers2[3] = 66;
        numbers2[4] = 8;

        Console.WriteLine(numbers2[2]);
        Console.WriteLine(numbers2[3]);

        string[] fruits = { "apple", "oranges", "bananas", "kiwi", "strawberry" };

        // Write whole array to console
        foreach(var fruit in fruits)
        {
            Console.WriteLine(fruit.ToString());
        }

        // index specific character of an item in the array
        Console.WriteLine(fruits[2][1]);
    }
}