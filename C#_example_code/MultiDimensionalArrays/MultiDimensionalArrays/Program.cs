// MultiDimensionalArrays

using System;

class Program
{
    static void Main()
    {
        int[,] table = new int[4, 5]; // Create 4x5 2D array
        table[0, 0] = 42;             // Write value to element in 2D array
        int number = table[0, 0];     // Read value from element in 2D array
        Console.WriteLine(number);    // output: 42
    }
}