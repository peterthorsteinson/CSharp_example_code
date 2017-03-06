// DivideByZeroDoubleExplicitThrow

using System;

class Program
{
    static double DivideDoubles(double dividend, double divisor)
    {
        // explicitly throw exception if bad divisor
        if (divisor == 0)
        {
            throw new System.DivideByZeroException();
        }

        return dividend / divisor;
    }

    static void Main()
    {
        double dividend, divisor;
        double result;

        try
        {
            dividend = 10.0; divisor = 2.0;
            result = DivideDoubles(dividend, divisor);
            Console.WriteLine(result);  // output: 5.0
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine(e.Message);
        }

        try
        {
            dividend = 10.0; divisor = 0.0;
            result = DivideDoubles(dividend, divisor);
            Console.WriteLine(result);  // Never get here
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine(e.Message); // Get here
        }

        try
        {
            dividend = 0.0; divisor = 0.0;
            result = DivideDoubles(dividend, divisor);
            Console.WriteLine(result);  // Never get here
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine(e.Message); // Get here
        }

        // Get here safe and sound
        Console.WriteLine("Program terminated normally.");
    }
}