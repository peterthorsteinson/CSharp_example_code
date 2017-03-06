// UnwindingCallStack

using System;

class Program
{
    static void AnotherMethod()
    {
        // hard throw for demonstration purposes
        throw new Exception("Ooops!");
    }
    static void Main()
    {
        try
        {
            Console.WriteLine("Calling"); // output: Calling
            AnotherMethod();
            Console.WriteLine("Called"); // Never executed
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message); // output: Ooops!
        }

        Console.WriteLine("Done"); // output: Done
    }
}