// DivideByZeroDouble

using System;

class Program
{
    static double DivideDoubles(double dividend, double divisor)
    {
        // will never throw exception
        return dividend / divisor;
    }

    static void Main()
    {
        double dividend, divisor;
        double result;

        dividend = 10.0; divisor = 2.0;
        result = DivideDoubles(dividend, divisor);
        Console.WriteLine(result);  // output: 5.0

        dividend = 10.0; divisor = 0.0;
        result = DivideDoubles(dividend, divisor);
        Console.WriteLine(result);  // output: Infinity

        dividend = 0.0; divisor = 0.0;
        result = DivideDoubles(dividend, divisor);
        Console.WriteLine(result); // output: NaN

        // No exception, so we do get here
        Console.WriteLine("Program terminated normally.");
    }
}

