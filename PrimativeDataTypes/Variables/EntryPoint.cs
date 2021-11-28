// Variables in C Sharp have three elements: Data Type, Name, Payload
// Variable names should be written in camelCase 

namespace Variables
{
    class EntryPoint
    {
        static void Main()
        {
            int age = 30;
            string firstName = "Jayden";

            System.Console.WriteLine(age);
            System.Console.WriteLine(firstName);
            // Concatenation: 
            System.Console.WriteLine(firstName + " is " + age + " Years Old");
        }
    }
}
