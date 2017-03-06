// AlternativeToExceptionHandling

using System;

class Program
{
    static int? DivideIntegersWithoutException(int? dividend, int? divisor)
    {
        // will not throw exception if divisor == 0
        if (divisor == 0) return null; // avoid throwing exception
        return dividend / divisor;
    }

    static void Main()
    {
        int? dividend, divisor;
        int? result;

        dividend = 42; divisor = 2;
        result = DivideIntegersWithoutException(dividend, divisor);
        Console.WriteLine(result); // output: 21
        dividend = 42; divisor = 0;
        result = DivideIntegersWithoutException(dividend, divisor);
        if (result != null)
            Console.WriteLine(result); // skipped if null result

        // get here safe and sound
        Console.WriteLine("Program terminated normally.");
    }
}

