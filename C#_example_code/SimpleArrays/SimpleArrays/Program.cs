// SimpleArrays

using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = new int[5]; // array of 5 zero elements
        Console.Write("Array Length: {0}", numbers.Length);

        Console.WriteLine("\nUsing for loop over array:");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write($"{numbers[i]} ");
        }

        Console.Write("\nAssigning array elements:");
        numbers[0] = 1;
        numbers[1] = 2;
        numbers[2] = 3;
        numbers[3] = 4;
        numbers[4] = 5;

        Console.WriteLine("\nUsing foreach-in loop over array:");
        foreach (int element in numbers)
        {
            Console.Write(element + " ");
        }

        Console.WriteLine("Array initialization syntax:");
        string[] strings = new string[5]; // array of 5 null elements
        int[] moreNumbers = new int[5] { 10, 20, 30, 40, 50 };
        Console.WriteLine(moreNumbers[3]);
        string[] names = new string[3] { "Dick", "Jane", "Sally" };
        Console.WriteLine(names[2]);

        Console.WriteLine();
    }
}

