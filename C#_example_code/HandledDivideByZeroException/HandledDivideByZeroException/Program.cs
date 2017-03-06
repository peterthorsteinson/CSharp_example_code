// HandledDivideByZeroException

using System;

class Program
{
    static int DivideIntegers(int dividend, int divisor)
    {
        // will throw exception if divisor == 0
        return dividend / divisor;
    }

    static void Main()
    {
        int dividend = 42, divisor = 0;
        int result;

        try
        {
            result = DivideIntegers(dividend, divisor);
            Console.WriteLine(result);
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine(e.Message);
        }

        // get here safe and sound
        Console.WriteLine("Program terminated normally.");
    }
}

