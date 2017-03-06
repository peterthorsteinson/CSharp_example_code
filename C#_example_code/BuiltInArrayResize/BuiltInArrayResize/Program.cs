// BuiltInArrayResize

using System;

class Program
{
    static void Main()
    {
        // Initialize array to nine elements
        String[] stringArray = {
            "The", "quick", "brown", "fox", "jumps",
            "over", "the", "lazy", "dog"};
        Console.WriteLine(stringArray.Length); // output: 9

        // Resize array to size three elements longer
        Array.Resize(ref stringArray, stringArray.Length + 3);
        Console.WriteLine(stringArray.Length); // output: 12
    }
}
