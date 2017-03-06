// ForEach

using System;

class Program
{
    static void Main(string[] args)
    {
        string[] rainbow = new string[] {
            "Red", "Orange", "Yellow", "Green", "Blue", "Violet" };

        foreach (string color in rainbow)
        {
            Console.WriteLine(color);
        }
    }
}

