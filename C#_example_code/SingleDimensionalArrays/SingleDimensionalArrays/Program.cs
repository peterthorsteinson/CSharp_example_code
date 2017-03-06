// SingleDimensionalArrays 

using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = new int[5]; // array of 5 zero elements
        numbers[0] = 42;            // Write a value to an element in the array
        int number = numbers[0];    // Read a value from an element in the array
        Console.WriteLine(number);  // output: 42
    }
}
