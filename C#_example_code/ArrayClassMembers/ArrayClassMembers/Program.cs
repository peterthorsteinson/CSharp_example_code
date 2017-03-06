// ArrayClassMembers

using System;

class Program
{
    static void Main()
    {
        const int length = 10;
        int[] array = new int[length];
        Random random = new Random();
        for (int i = 0; i < length; i++)
            array[i] = random.Next(1, 101); // 1-100 inclusive
        Console.WriteLine(
            "Length: " + array.Length);     // array property
        Console.WriteLine("Before sort:");
        foreach (int x in array)
            Console.WriteLine(x);
        Array.Sort(array);                  // array static method
        Console.WriteLine("After sort:");
        foreach (int x in array)
            Console.WriteLine(x);
    }
}

