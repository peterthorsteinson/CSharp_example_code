// JaggedArrays

using System;

class Program
{
    static void Main()
    {
        string[][] textStrings;        // Declare array of array of string
        textStrings = new string[4][]; // Create primary array of array
        textStrings[0] = new string[] { "One", "Two" };
        textStrings[1] = new string[] { "Buckle", "my", "shoe" };
        textStrings[2] = new string[] { "Three", "Four" };
        textStrings[3] = new string[] { "Open", "the", "door" };
        foreach (string[] subArray in textStrings)
        {
            foreach (string word in subArray)
            {
                Console.Write(word + " ");
            }
            Console.WriteLine();
        }
    }
}
