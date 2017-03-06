// GenericMethod 

using System;

class Program
{
    static void NonGenericSwapMethod(ref int lhs, ref int rhs)
    {
        int temp;
        temp = lhs;
        lhs = rhs;
        rhs = temp;
    }

    static void NonGenericSwapMethod(ref string lhs, ref string rhs)
    {
        string temp;
        temp = lhs;
        lhs = rhs;
        rhs = temp;
    }

    static void GenericSwapMethod<T>(ref T lhs, ref T rhs)
    {
        T temp;
        temp = lhs;
        lhs = rhs;
        rhs = temp;
    }

    static void Main()
    {
        Console.WriteLine("NonGenericSwapMethod");
        {
            int x = 3;
            int y = 4;
            Console.WriteLine($"x: {x}, y: {y}");
            NonGenericSwapMethod(ref x, ref y);
            Console.WriteLine($"x: {x}, y: {y}");
        }
        {
            string x = "up";
            string y = "down";
            Console.WriteLine($"x: {x}, y: {y}");
            NonGenericSwapMethod(ref x, ref y);
            Console.WriteLine($"x: {x}, y: {y}");
        }

        Console.WriteLine("\nGenericSwapMethod");
        {
            int x = 3;
            int y = 4;
            Console.WriteLine($"x: {x}, y: {y}");
            GenericSwapMethod<int>(ref x, ref y);
            Console.WriteLine($"x: {x}, y: {y}");
        }
        {
            string x = "up";
            string y = "down";
            Console.WriteLine($"x: {x}, y: {y}");
            GenericSwapMethod<string>(ref x, ref y);
            Console.WriteLine($"x: {x}, y: {y}");
        }
    }
}

