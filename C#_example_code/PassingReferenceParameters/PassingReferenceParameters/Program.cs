// PassingReferenceParameters

using System;

class Program
{
    static void MethodTakingArray(int[] intArray)
    {
        for (int i = 0; i < intArray.Length; i++)
        {
            intArray[i] *= 10; // make changes
        }
    }

    static void MethodTakingString(string str)
    {
        str = "changed string";  // make changes
    }

    static void Main()
    {
        int[] intArray = { 1, 2, 3 };
        MethodTakingArray(intArray);
        for (int i = 0; i < intArray.Length; i++)
        {
            Console.WriteLine(intArray[i]); // output: 10 20 30
        }
        Console.WriteLine();

        string str = "original string";
        MethodTakingString(str);
        Console.WriteLine(str); // output: original string
        Console.WriteLine();
    }
}

