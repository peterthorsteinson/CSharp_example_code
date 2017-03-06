// UnhandledDivideByZeroException

using System;

class Program
{
    static int DivideIntegers(int dividend, int divisor)
    {
        // will throw exception if divisory == 0
        return dividend / divisor;
    }

    static void Main()
    {
        int dividend = 42, divisor = 0;
        int result;

        result = DivideIntegers(dividend, divisor);
        Console.WriteLine(result);

        // never get here due to unhandled exception
        Console.WriteLine("Program terminated normally.");
    }
}
